// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v7/resources/merchant_center_link.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V7.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v7/resources/merchant_center_link.proto</summary>
  public static partial class MerchantCenterLinkReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v7/resources/merchant_center_link.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MerchantCenterLinkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvYWRzL2dvb2dsZWFkcy92Ny9yZXNvdXJjZXMvbWVyY2hhbnRf",
            "Y2VudGVyX2xpbmsucHJvdG8SIWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LnJl",
            "c291cmNlcxo/Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjcvZW51bXMvbWVyY2hh",
            "bnRfY2VudGVyX2xpbmtfc3RhdHVzLnByb3RvGh9nb29nbGUvYXBpL2ZpZWxk",
            "X2JlaGF2aW9yLnByb3RvGhlnb29nbGUvYXBpL3Jlc291cmNlLnByb3RvGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIqgDChJNZXJjaGFudENlbnRl",
            "ckxpbmsSSgoNcmVzb3VyY2VfbmFtZRgBIAEoCUIz4EEF+kEtCitnb29nbGVh",
            "ZHMuZ29vZ2xlYXBpcy5jb20vTWVyY2hhbnRDZW50ZXJMaW5rEhQKAmlkGAYg",
            "ASgDQgPgQQNIAIgBARIuChxtZXJjaGFudF9jZW50ZXJfYWNjb3VudF9uYW1l",
            "GAcgASgJQgPgQQNIAYgBARJkCgZzdGF0dXMYBSABKA4yVC5nb29nbGUuYWRz",
            "Lmdvb2dsZWFkcy52Ny5lbnVtcy5NZXJjaGFudENlbnRlckxpbmtTdGF0dXNF",
            "bnVtLk1lcmNoYW50Q2VudGVyTGlua1N0YXR1czpy6kFvCitnb29nbGVhZHMu",
            "Z29vZ2xlYXBpcy5jb20vTWVyY2hhbnRDZW50ZXJMaW5rEkBjdXN0b21lcnMv",
            "e2N1c3RvbWVyX2lkfS9tZXJjaGFudENlbnRlckxpbmtzL3ttZXJjaGFudF9j",
            "ZW50ZXJfaWR9QgUKA19pZEIfCh1fbWVyY2hhbnRfY2VudGVyX2FjY291bnRf",
            "bmFtZUKEAgolY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY3LnJlc291cmNl",
            "c0IXTWVyY2hhbnRDZW50ZXJMaW5rUHJvdG9QAVpKZ29vZ2xlLmdvbGFuZy5v",
            "cmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y3L3Jlc291",
            "cmNlcztyZXNvdXJjZXOiAgNHQUGqAiFHb29nbGUuQWRzLkdvb2dsZUFkcy5W",
            "Ny5SZXNvdXJjZXPKAiFHb29nbGVcQWRzXEdvb2dsZUFkc1xWN1xSZXNvdXJj",
            "ZXPqAiVHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWNzo6UmVzb3VyY2VzYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V7.Enums.MerchantCenterLinkStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V7.Resources.MerchantCenterLink), global::Google.Ads.GoogleAds.V7.Resources.MerchantCenterLink.Parser, new[]{ "ResourceName", "Id", "MerchantCenterAccountName", "Status" }, new[]{ "Id", "MerchantCenterAccountName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A data sharing connection, proposed or in use,
  /// between a Google Ads Customer and a Merchant Center account.
  /// </summary>
  public sealed partial class MerchantCenterLink : pb::IMessage<MerchantCenterLink>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MerchantCenterLink> _parser = new pb::MessageParser<MerchantCenterLink>(() => new MerchantCenterLink());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MerchantCenterLink> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V7.Resources.MerchantCenterLinkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantCenterLink() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantCenterLink(MerchantCenterLink other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      merchantCenterAccountName_ = other.merchantCenterAccountName_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MerchantCenterLink Clone() {
      return new MerchantCenterLink(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the merchant center link.
    /// Merchant center link resource names have the form:
    ///
    /// `customers/{customer_id}/merchantCenterLinks/{merchant_center_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 6;
    private long id_;
    /// <summary>
    /// Output only. The ID of the Merchant Center account.
    /// This field is readonly.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "merchant_center_account_name" field.</summary>
    public const int MerchantCenterAccountNameFieldNumber = 7;
    private string merchantCenterAccountName_;
    /// <summary>
    /// Output only. The name of the Merchant Center account.
    /// This field is readonly.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string MerchantCenterAccountName {
      get { return merchantCenterAccountName_ ?? ""; }
      set {
        merchantCenterAccountName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "merchant_center_account_name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasMerchantCenterAccountName {
      get { return merchantCenterAccountName_ != null; }
    }
    /// <summary>Clears the value of the "merchant_center_account_name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearMerchantCenterAccountName() {
      merchantCenterAccountName_ = null;
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V7.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus status_ = global::Google.Ads.GoogleAds.V7.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus.Unspecified;
    /// <summary>
    /// The status of the link.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V7.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MerchantCenterLink);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MerchantCenterLink other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (MerchantCenterAccountName != other.MerchantCenterAccountName) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (HasMerchantCenterAccountName) hash ^= MerchantCenterAccountName.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus.Unspecified) hash ^= Status.GetHashCode();
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
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (HasId) {
        output.WriteRawTag(48);
        output.WriteInt64(Id);
      }
      if (HasMerchantCenterAccountName) {
        output.WriteRawTag(58);
        output.WriteString(MerchantCenterAccountName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (HasId) {
        output.WriteRawTag(48);
        output.WriteInt64(Id);
      }
      if (HasMerchantCenterAccountName) {
        output.WriteRawTag(58);
        output.WriteString(MerchantCenterAccountName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (HasMerchantCenterAccountName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(MerchantCenterAccountName);
      }
      if (Status != global::Google.Ads.GoogleAds.V7.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MerchantCenterLink other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasMerchantCenterAccountName) {
        MerchantCenterAccountName = other.MerchantCenterAccountName;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V7.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus.Unspecified) {
        Status = other.Status;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
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
            ResourceName = input.ReadString();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V7.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus) input.ReadEnum();
            break;
          }
          case 48: {
            Id = input.ReadInt64();
            break;
          }
          case 58: {
            MerchantCenterAccountName = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V7.Enums.MerchantCenterLinkStatusEnum.Types.MerchantCenterLinkStatus) input.ReadEnum();
            break;
          }
          case 48: {
            Id = input.ReadInt64();
            break;
          }
          case 58: {
            MerchantCenterAccountName = input.ReadString();
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
