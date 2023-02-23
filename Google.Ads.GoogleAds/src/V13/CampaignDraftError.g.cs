// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/errors/campaign_draft_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/errors/campaign_draft_error.proto</summary>
  public static partial class CampaignDraftErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/errors/campaign_draft_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignDraftErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjpnb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvZXJyb3JzL2NhbXBhaWduX2Ry",
            "YWZ0X2Vycm9yLnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTMuZXJy",
            "b3JzIsgDChZDYW1wYWlnbkRyYWZ0RXJyb3JFbnVtIq0DChJDYW1wYWlnbkRy",
            "YWZ0RXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESGAoURFVQ",
            "TElDQVRFX0RSQUZUX05BTUUQAhIqCiZJTlZBTElEX1NUQVRVU19UUkFOU0lU",
            "SU9OX0ZST01fUkVNT1ZFRBADEisKJ0lOVkFMSURfU1RBVFVTX1RSQU5TSVRJ",
            "T05fRlJPTV9QUk9NT1RFRBAEEjEKLUlOVkFMSURfU1RBVFVTX1RSQU5TSVRJ",
            "T05fRlJPTV9QUk9NT1RFX0ZBSUxFRBAFEiAKHENVU1RPTUVSX0NBTk5PVF9D",
            "UkVBVEVfRFJBRlQQBhIgChxDQU1QQUlHTl9DQU5OT1RfQ1JFQVRFX0RSQUZU",
            "EAcSGAoUSU5WQUxJRF9EUkFGVF9DSEFOR0UQCBIdChlJTlZBTElEX1NUQVRV",
            "U19UUkFOU0lUSU9OEAkSLQopTUFYX05VTUJFUl9PRl9EUkFGVFNfUEVSX0NB",
            "TVBBSUdOX1JFQUNIRUQQChInCiNMSVNUX0VSUk9SU19GT1JfUFJPTU9URURf",
            "RFJBRlRfT05MWRALQvcBCiNjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEz",
            "LmVycm9yc0IXQ2FtcGFpZ25EcmFmdEVycm9yUHJvdG9QAVpFZ29vZ2xlLmdv",
            "bGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Yx",
            "My9lcnJvcnM7ZXJyb3JzogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMu",
            "VjEzLkVycm9yc8oCH0dvb2dsZVxBZHNcR29vZ2xlQWRzXFYxM1xFcnJvcnPq",
            "AiNHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTM6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Errors.CampaignDraftErrorEnum), global::Google.Ads.GoogleAds.V13.Errors.CampaignDraftErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V13.Errors.CampaignDraftErrorEnum.Types.CampaignDraftError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible campaign draft errors.
  /// </summary>
  public sealed partial class CampaignDraftErrorEnum : pb::IMessage<CampaignDraftErrorEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CampaignDraftErrorEnum> _parser = new pb::MessageParser<CampaignDraftErrorEnum>(() => new CampaignDraftErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CampaignDraftErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Errors.CampaignDraftErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignDraftErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignDraftErrorEnum(CampaignDraftErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CampaignDraftErrorEnum Clone() {
      return new CampaignDraftErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CampaignDraftErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CampaignDraftErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CampaignDraftErrorEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the CampaignDraftErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible campaign draft errors.
      /// </summary>
      public enum CampaignDraftError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// A draft with this name already exists for this campaign.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_DRAFT_NAME")] DuplicateDraftName = 2,
        /// <summary>
        /// The draft is removed and cannot be transitioned to another status.
        /// </summary>
        [pbr::OriginalName("INVALID_STATUS_TRANSITION_FROM_REMOVED")] InvalidStatusTransitionFromRemoved = 3,
        /// <summary>
        /// The draft has been promoted and cannot be transitioned to the specified
        /// status.
        /// </summary>
        [pbr::OriginalName("INVALID_STATUS_TRANSITION_FROM_PROMOTED")] InvalidStatusTransitionFromPromoted = 4,
        /// <summary>
        /// The draft has failed to be promoted and cannot be transitioned to the
        /// specified status.
        /// </summary>
        [pbr::OriginalName("INVALID_STATUS_TRANSITION_FROM_PROMOTE_FAILED")] InvalidStatusTransitionFromPromoteFailed = 5,
        /// <summary>
        /// This customer is not allowed to create drafts.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_CANNOT_CREATE_DRAFT")] CustomerCannotCreateDraft = 6,
        /// <summary>
        /// This campaign is not allowed to create drafts.
        /// </summary>
        [pbr::OriginalName("CAMPAIGN_CANNOT_CREATE_DRAFT")] CampaignCannotCreateDraft = 7,
        /// <summary>
        /// This modification cannot be made on a draft.
        /// </summary>
        [pbr::OriginalName("INVALID_DRAFT_CHANGE")] InvalidDraftChange = 8,
        /// <summary>
        /// The draft cannot be transitioned to the specified status from its
        /// current status.
        /// </summary>
        [pbr::OriginalName("INVALID_STATUS_TRANSITION")] InvalidStatusTransition = 9,
        /// <summary>
        /// The campaign has reached the maximum number of drafts that can be created
        /// for a campaign throughout its lifetime. No additional drafts can be
        /// created for this campaign. Removed drafts also count towards this limit.
        /// </summary>
        [pbr::OriginalName("MAX_NUMBER_OF_DRAFTS_PER_CAMPAIGN_REACHED")] MaxNumberOfDraftsPerCampaignReached = 10,
        /// <summary>
        /// ListAsyncErrors was called without first promoting the draft.
        /// </summary>
        [pbr::OriginalName("LIST_ERRORS_FOR_PROMOTED_DRAFT_ONLY")] ListErrorsForPromotedDraftOnly = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
