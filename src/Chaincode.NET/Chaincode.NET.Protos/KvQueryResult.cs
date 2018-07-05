// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ledger/queryresult/kv_query_result.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Queryresult {

  /// <summary>Holder for reflection information generated from ledger/queryresult/kv_query_result.proto</summary>
  public static partial class KvQueryResultReflection {

    #region Descriptor
    /// <summary>File descriptor for ledger/queryresult/kv_query_result.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static KvQueryResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CihsZWRnZXIvcXVlcnlyZXN1bHQva3ZfcXVlcnlfcmVzdWx0LnByb3RvEgtx",
            "dWVyeXJlc3VsdBofZ29vZ2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byIz",
            "CgJLVhIRCgluYW1lc3BhY2UYASABKAkSCwoDa2V5GAIgASgJEg0KBXZhbHVl",
            "GAMgASgMInEKD0tleU1vZGlmaWNhdGlvbhINCgV0eF9pZBgBIAEoCRINCgV2",
            "YWx1ZRgCIAEoDBItCgl0aW1lc3RhbXAYAyABKAsyGi5nb29nbGUucHJvdG9i",
            "dWYuVGltZXN0YW1wEhEKCWlzX2RlbGV0ZRgEIAEoCEJrCjBvcmcuaHlwZXJs",
            "ZWRnZXIuZmFicmljLnByb3Rvcy5sZWRnZXIucXVlcnlyZXN1bHRaN2dpdGh1",
            "Yi5jb20vaHlwZXJsZWRnZXIvZmFicmljL3Byb3Rvcy9sZWRnZXIvcXVlcnly",
            "ZXN1bHRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Queryresult.KV), global::Queryresult.KV.Parser, new[]{ "Namespace", "Key", "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Queryresult.KeyModification), global::Queryresult.KeyModification.Parser, new[]{ "TxId", "Value", "Timestamp", "IsDelete" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// KV -- QueryResult for range/execute query. Holds a key and corresponding value.
  /// </summary>
  public sealed partial class KV : pb::IMessage<KV> {
    private static readonly pb::MessageParser<KV> _parser = new pb::MessageParser<KV>(() => new KV());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KV> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Queryresult.KvQueryResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KV() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KV(KV other) : this() {
      namespace_ = other.namespace_;
      key_ = other.key_;
      value_ = other.value_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KV Clone() {
      return new KV(this);
    }

    /// <summary>Field number for the "namespace" field.</summary>
    public const int NamespaceFieldNumber = 1;
    private string namespace_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Namespace {
      get { return namespace_; }
      set {
        namespace_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "key" field.</summary>
    public const int KeyFieldNumber = 2;
    private string key_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Key {
      get { return key_; }
      set {
        key_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 3;
    private pb::ByteString value_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KV);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KV other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Namespace != other.Namespace) return false;
      if (Key != other.Key) return false;
      if (Value != other.Value) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Namespace.Length != 0) hash ^= Namespace.GetHashCode();
      if (Key.Length != 0) hash ^= Key.GetHashCode();
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Namespace.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Namespace);
      }
      if (Key.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Key);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Value);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Namespace.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Namespace);
      }
      if (Key.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Key);
      }
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Value);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KV other) {
      if (other == null) {
        return;
      }
      if (other.Namespace.Length != 0) {
        Namespace = other.Namespace;
      }
      if (other.Key.Length != 0) {
        Key = other.Key;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Namespace = input.ReadString();
            break;
          }
          case 18: {
            Key = input.ReadString();
            break;
          }
          case 26: {
            Value = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// KeyModification -- QueryResult for history query. Holds a transaction ID, value,
  /// timestamp, and delete marker which resulted from a history query.
  /// </summary>
  public sealed partial class KeyModification : pb::IMessage<KeyModification> {
    private static readonly pb::MessageParser<KeyModification> _parser = new pb::MessageParser<KeyModification>(() => new KeyModification());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<KeyModification> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Queryresult.KvQueryResultReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeyModification() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeyModification(KeyModification other) : this() {
      txId_ = other.txId_;
      value_ = other.value_;
      Timestamp = other.timestamp_ != null ? other.Timestamp.Clone() : null;
      isDelete_ = other.isDelete_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public KeyModification Clone() {
      return new KeyModification(this);
    }

    /// <summary>Field number for the "tx_id" field.</summary>
    public const int TxIdFieldNumber = 1;
    private string txId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string TxId {
      get { return txId_; }
      set {
        txId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private pb::ByteString value_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "timestamp" field.</summary>
    public const int TimestampFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp timestamp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Timestamp {
      get { return timestamp_; }
      set {
        timestamp_ = value;
      }
    }

    /// <summary>Field number for the "is_delete" field.</summary>
    public const int IsDeleteFieldNumber = 4;
    private bool isDelete_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsDelete {
      get { return isDelete_; }
      set {
        isDelete_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as KeyModification);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(KeyModification other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TxId != other.TxId) return false;
      if (Value != other.Value) return false;
      if (!object.Equals(Timestamp, other.Timestamp)) return false;
      if (IsDelete != other.IsDelete) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (TxId.Length != 0) hash ^= TxId.GetHashCode();
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      if (timestamp_ != null) hash ^= Timestamp.GetHashCode();
      if (IsDelete != false) hash ^= IsDelete.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (TxId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(TxId);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(18);
        output.WriteBytes(Value);
      }
      if (timestamp_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Timestamp);
      }
      if (IsDelete != false) {
        output.WriteRawTag(32);
        output.WriteBool(IsDelete);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (TxId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TxId);
      }
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Value);
      }
      if (timestamp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Timestamp);
      }
      if (IsDelete != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(KeyModification other) {
      if (other == null) {
        return;
      }
      if (other.TxId.Length != 0) {
        TxId = other.TxId;
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
      if (other.timestamp_ != null) {
        if (timestamp_ == null) {
          timestamp_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Timestamp.MergeFrom(other.Timestamp);
      }
      if (other.IsDelete != false) {
        IsDelete = other.IsDelete;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            TxId = input.ReadString();
            break;
          }
          case 18: {
            Value = input.ReadBytes();
            break;
          }
          case 26: {
            if (timestamp_ == null) {
              timestamp_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(timestamp_);
            break;
          }
          case 32: {
            IsDelete = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
