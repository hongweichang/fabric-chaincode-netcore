using Google.Protobuf;

namespace Chaincode.NET.Extensions
{
    public static class IntExtensions
    {
        public static ByteString ToByteString(this int value)
        {
            return value.ToString().ToByteString();
        }
    }
}