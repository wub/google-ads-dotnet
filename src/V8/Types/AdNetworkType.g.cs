// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v8/enums/ad_network_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V8.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v8/enums/ad_network_type.proto</summary>
  public static partial class AdNetworkTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v8/enums/ad_network_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdNetworkTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92OC9lbnVtcy9hZF9uZXR3b3JrX3R5",
            "cGUucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY4LmVudW1zGhxnb29n",
            "bGUvYXBpL2Fubm90YXRpb25zLnByb3RvIqMBChFBZE5ldHdvcmtUeXBlRW51",
            "bSKNAQoNQWROZXR3b3JrVHlwZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05P",
            "V04QARIKCgZTRUFSQ0gQAhITCg9TRUFSQ0hfUEFSVE5FUlMQAxILCgdDT05U",
            "RU5UEAQSEgoOWU9VVFVCRV9TRUFSQ0gQBRIRCg1ZT1VUVUJFX1dBVENIEAYS",
            "CQoFTUlYRUQQB0LnAQohY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnY4LmVu",
            "dW1zQhJBZE5ldHdvcmtUeXBlUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcv",
            "Z2VucHJvdG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3Y4L2VudW1zO2Vu",
            "dW1zogIDR0FBqgIdR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjguRW51bXPKAh1H",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWOFxFbnVtc+oCIUdvb2dsZTo6QWRzOjpH",
            "b29nbGVBZHM6OlY4OjpFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V8.Enums.AdNetworkTypeEnum), global::Google.Ads.GoogleAds.V8.Enums.AdNetworkTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V8.Enums.AdNetworkTypeEnum.Types.AdNetworkType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enumeration of Google Ads network types.
  /// </summary>
  public sealed partial class AdNetworkTypeEnum : pb::IMessage<AdNetworkTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AdNetworkTypeEnum> _parser = new pb::MessageParser<AdNetworkTypeEnum>(() => new AdNetworkTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AdNetworkTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V8.Enums.AdNetworkTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdNetworkTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdNetworkTypeEnum(AdNetworkTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AdNetworkTypeEnum Clone() {
      return new AdNetworkTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AdNetworkTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AdNetworkTypeEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AdNetworkTypeEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the AdNetworkTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enumerates Google Ads network types.
      /// </summary>
      public enum AdNetworkType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The value is unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Google search.
        /// </summary>
        [pbr::OriginalName("SEARCH")] Search = 2,
        /// <summary>
        /// Search partners.
        /// </summary>
        [pbr::OriginalName("SEARCH_PARTNERS")] SearchPartners = 3,
        /// <summary>
        /// Display Network.
        /// </summary>
        [pbr::OriginalName("CONTENT")] Content = 4,
        /// <summary>
        /// YouTube Search.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_SEARCH")] YoutubeSearch = 5,
        /// <summary>
        /// YouTube Videos
        /// </summary>
        [pbr::OriginalName("YOUTUBE_WATCH")] YoutubeWatch = 6,
        /// <summary>
        /// Cross-network.
        /// </summary>
        [pbr::OriginalName("MIXED")] Mixed = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
