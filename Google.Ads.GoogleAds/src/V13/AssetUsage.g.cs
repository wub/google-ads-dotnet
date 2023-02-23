// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/common/asset_usage.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/common/asset_usage.proto</summary>
  public static partial class AssetUsageReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/common/asset_usage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetUsageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvY29tbW9uL2Fzc2V0X3VzYWdl",
            "LnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTMuY29tbW9uGjxnb29n",
            "bGUvYWRzL2dvb2dsZWFkcy92MTMvZW51bXMvc2VydmVkX2Fzc2V0X2ZpZWxk",
            "X3R5cGUucHJvdG8iiwEKCkFzc2V0VXNhZ2USDQoFYXNzZXQYASABKAkSbgoX",
            "c2VydmVkX2Fzc2V0X2ZpZWxkX3R5cGUYAiABKA4yTS5nb29nbGUuYWRzLmdv",
            "b2dsZWFkcy52MTMuZW51bXMuU2VydmVkQXNzZXRGaWVsZFR5cGVFbnVtLlNl",
            "cnZlZEFzc2V0RmllbGRUeXBlQu8BCiNjb20uZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjEzLmNvbW1vbkIPQXNzZXRVc2FnZVByb3RvUAFaRWdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTMv",
            "Y29tbW9uO2NvbW1vbqICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYx",
            "My5Db21tb27KAh9Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTNcQ29tbW9u6gIj",
            "R29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjEzOjpDb21tb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V13.Enums.ServedAssetFieldTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Common.AssetUsage), global::Google.Ads.GoogleAds.V13.Common.AssetUsage.Parser, new[]{ "Asset", "ServedAssetFieldType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Contains the usage information of the asset.
  /// </summary>
  public sealed partial class AssetUsage : pb::IMessage<AssetUsage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AssetUsage> _parser = new pb::MessageParser<AssetUsage>(() => new AssetUsage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AssetUsage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Common.AssetUsageReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetUsage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetUsage(AssetUsage other) : this() {
      asset_ = other.asset_;
      servedAssetFieldType_ = other.servedAssetFieldType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AssetUsage Clone() {
      return new AssetUsage(this);
    }

    /// <summary>Field number for the "asset" field.</summary>
    public const int AssetFieldNumber = 1;
    private string asset_ = "";
    /// <summary>
    /// Resource name of the asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Asset {
      get { return asset_; }
      set {
        asset_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "served_asset_field_type" field.</summary>
    public const int ServedAssetFieldTypeFieldNumber = 2;
    private global::Google.Ads.GoogleAds.V13.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType servedAssetFieldType_ = global::Google.Ads.GoogleAds.V13.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified;
    /// <summary>
    /// The served field type of the asset.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V13.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType ServedAssetFieldType {
      get { return servedAssetFieldType_; }
      set {
        servedAssetFieldType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AssetUsage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AssetUsage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Asset != other.Asset) return false;
      if (ServedAssetFieldType != other.ServedAssetFieldType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Asset.Length != 0) hash ^= Asset.GetHashCode();
      if (ServedAssetFieldType != global::Google.Ads.GoogleAds.V13.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) hash ^= ServedAssetFieldType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Asset.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Asset);
      }
      if (ServedAssetFieldType != global::Google.Ads.GoogleAds.V13.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ServedAssetFieldType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Asset.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Asset);
      }
      if (ServedAssetFieldType != global::Google.Ads.GoogleAds.V13.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) ServedAssetFieldType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Asset.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Asset);
      }
      if (ServedAssetFieldType != global::Google.Ads.GoogleAds.V13.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ServedAssetFieldType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AssetUsage other) {
      if (other == null) {
        return;
      }
      if (other.Asset.Length != 0) {
        Asset = other.Asset;
      }
      if (other.ServedAssetFieldType != global::Google.Ads.GoogleAds.V13.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Unspecified) {
        ServedAssetFieldType = other.ServedAssetFieldType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Asset = input.ReadString();
            break;
          }
          case 16: {
            ServedAssetFieldType = (global::Google.Ads.GoogleAds.V13.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType) input.ReadEnum();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Asset = input.ReadString();
            break;
          }
          case 16: {
            ServedAssetFieldType = (global::Google.Ads.GoogleAds.V13.Enums.ServedAssetFieldTypeEnum.Types.ServedAssetFieldType) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
