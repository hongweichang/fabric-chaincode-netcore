using System;
using System.Threading.Tasks;
using Chaincode.NET.Protos;
using Google.Protobuf;
using Grpc.Core;
using Grpc.Core.Logging;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Thinktecture.HyperledgerFabric.Chaincode.NET.Chaincode;
using Thinktecture.HyperledgerFabric.Chaincode.NET.Settings;

namespace Thinktecture.HyperledgerFabric.Chaincode.NET.Handler
{
    public class Shim
    {
        private readonly ChaincodeSettings _chaincodeSettings;
        private readonly IHandlerFactory _handlerFactory;
        private readonly ILogger<Shim> _logger;

        public Shim(
            IOptions<ChaincodeSettings> chaincodeSettings,
            ILogger<Shim> logger,
            IHandlerFactory handlerFactory
        )
        {
            if (chaincodeSettings == null) throw new ArgumentNullException(nameof(chaincodeSettings));

            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _handlerFactory = handlerFactory ?? throw new ArgumentNullException(nameof(handlerFactory));
            _chaincodeSettings = chaincodeSettings.Value;

            if (_chaincodeSettings.LogGrpc) GrpcEnvironment.SetLogger(new ConsoleLogger());
        }

        public async Task<IHandler> Start()
        {
            var url = ParseUrl(_chaincodeSettings.PeerAddress);

            // TODO: TLS Stuff?

            var handler = _handlerFactory.Create(url.Host, url.Port);

            var chaincodeId = new ChaincodeID {Name = _chaincodeSettings.ChaincodeIdName};

            _logger.LogInformation("Registering with peer " +
                                   $"{url.Host}:{url.Port} as chaincode " +
                                   $"{_chaincodeSettings.ChaincodeIdName}");

            await handler.Chat(new ChaincodeMessage
            {
                Type = ChaincodeMessage.Types.Type.Register,
                Payload = chaincodeId.ToByteString()
            });

            return handler;
        }

        private (string Host, int Port) ParseUrl(string peerAddress)
        {
            if (peerAddress.Contains("://"))
                throw new Exception("Peer Address should not contain any protocol information.");

            var split = peerAddress.Split(':');

            if (split.Length != 2)
                throw new ArgumentException("Please provide peer address in the format of host:port");

            return (split[0], int.Parse(split[1]));
        }

        public static Response Success()
        {
            return Success(ByteString.Empty);
        }

        public static Response Success(ByteString payload)
        {
            return new Response
            {
                Status = (int) ResponseCodes.Ok,
                Payload = payload
            };
        }

        public static Response Error(string message)
        {
            return new Response
            {
                Status = (int) ResponseCodes.Error,
                Message = message
            };
        }

        public static Response Error(Exception exception)
        {
            return Error(exception.ToString());
        }
    }
}