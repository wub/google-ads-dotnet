// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v13/resources/topic_constant.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V13.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v13/resources/topic_constant.proto</summary>
  public static partial class TopicConstantReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v13/resources/topic_constant.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TopicConstantReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjdnb29nbGUvYWRzL2dvb2dsZWFkcy92MTMvcmVzb3VyY2VzL3RvcGljX2Nv",
            "bnN0YW50LnByb3RvEiJnb29nbGUuYWRzLmdvb2dsZWFkcy52MTMucmVzb3Vy",
            "Y2VzGh9nb29nbGUvYXBpL2ZpZWxkX2JlaGF2aW9yLnByb3RvGhlnb29nbGUv",
            "YXBpL3Jlc291cmNlLnByb3RvIrwCCg1Ub3BpY0NvbnN0YW50EkUKDXJlc291",
            "cmNlX25hbWUYASABKAlCLuBBA/pBKAomZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tL1RvcGljQ29uc3RhbnQSFAoCaWQYBSABKANCA+BBA0gAiAEBElIKFXRv",
            "cGljX2NvbnN0YW50X3BhcmVudBgGIAEoCUIu4EED+kEoCiZnb29nbGVhZHMu",
            "Z29vZ2xlYXBpcy5jb20vVG9waWNDb25zdGFudEgBiAEBEhEKBHBhdGgYByAD",
            "KAlCA+BBAzpG6kFDCiZnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vVG9waWND",
            "b25zdGFudBIZdG9waWNDb25zdGFudHMve3RvcGljX2lkfUIFCgNfaWRCGAoW",
            "X3RvcGljX2NvbnN0YW50X3BhcmVudEKEAgomY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxMy5yZXNvdXJjZXNCElRvcGljQ29uc3RhbnRQcm90b1ABWktn",
            "b29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29n",
            "bGVhZHMvdjEzL3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiJHb29nbGUu",
            "QWRzLkdvb2dsZUFkcy5WMTMuUmVzb3VyY2VzygIiR29vZ2xlXEFkc1xHb29n",
            "bGVBZHNcVjEzXFJlc291cmNlc+oCJkdvb2dsZTo6QWRzOjpHb29nbGVBZHM6",
            "OlYxMzo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V13.Resources.TopicConstant), global::Google.Ads.GoogleAds.V13.Resources.TopicConstant.Parser, new[]{ "ResourceName", "Id", "TopicConstantParent", "Path" }, new[]{ "Id", "TopicConstantParent" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Use topics to target or exclude placements in the Google Display Network
  /// based on the category into which the placement falls (for example,
  /// "Pets &amp; Animals/Pets/Dogs").
  /// </summary>
  public sealed partial class TopicConstant : pb::IMessage<TopicConstant>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TopicConstant> _parser = new pb::MessageParser<TopicConstant>(() => new TopicConstant());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TopicConstant> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V13.Resources.TopicConstantReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TopicConstant() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TopicConstant(TopicConstant other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      id_ = other.id_;
      topicConstantParent_ = other.topicConstantParent_;
      path_ = other.path_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TopicConstant Clone() {
      return new TopicConstant(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Output only. The resource name of the topic constant.
    /// topic constant resource names have the form:
    ///
    /// `topicConstants/{topic_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 5;
    private long id_;
    /// <summary>
    /// Output only. The ID of the topic.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Id {
      get { if ((_hasBits0 & 1) != 0) { return id_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        id_ = value;
      }
    }
    /// <summary>Gets whether the "id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "topic_constant_parent" field.</summary>
    public const int TopicConstantParentFieldNumber = 6;
    private string topicConstantParent_;
    /// <summary>
    /// Output only. Resource name of parent of the topic constant.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TopicConstantParent {
      get { return topicConstantParent_ ?? ""; }
      set {
        topicConstantParent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "topic_constant_parent" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasTopicConstantParent {
      get { return topicConstantParent_ != null; }
    }
    /// <summary>Clears the value of the "topic_constant_parent" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearTopicConstantParent() {
      topicConstantParent_ = null;
    }

    /// <summary>Field number for the "path" field.</summary>
    public const int PathFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _repeated_path_codec
        = pb::FieldCodec.ForString(58);
    private readonly pbc::RepeatedField<string> path_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Output only. The category to target or exclude. Each subsequent element in
    /// the array describes a more specific sub-category. For example,
    /// {"Pets &amp; Animals", "Pets", "Dogs"} represents the
    /// "Pets &amp; Animals/Pets/Dogs" category. List of available topic categories at
    /// https://developers.google.com/google-ads/api/reference/data/verticals
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<string> Path {
      get { return path_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TopicConstant);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TopicConstant other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (TopicConstantParent != other.TopicConstantParent) return false;
      if(!path_.Equals(other.path_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasId) hash ^= Id.GetHashCode();
      if (HasTopicConstantParent) hash ^= TopicConstantParent.GetHashCode();
      hash ^= path_.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (HasId) {
        output.WriteRawTag(40);
        output.WriteInt64(Id);
      }
      if (HasTopicConstantParent) {
        output.WriteRawTag(50);
        output.WriteString(TopicConstantParent);
      }
      path_.WriteTo(output, _repeated_path_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (HasId) {
        output.WriteRawTag(40);
        output.WriteInt64(Id);
      }
      if (HasTopicConstantParent) {
        output.WriteRawTag(50);
        output.WriteString(TopicConstantParent);
      }
      path_.WriteTo(ref output, _repeated_path_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (HasId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Id);
      }
      if (HasTopicConstantParent) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TopicConstantParent);
      }
      size += path_.CalculateSize(_repeated_path_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TopicConstant other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasId) {
        Id = other.Id;
      }
      if (other.HasTopicConstantParent) {
        TopicConstantParent = other.TopicConstantParent;
      }
      path_.Add(other.path_);
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
            ResourceName = input.ReadString();
            break;
          }
          case 40: {
            Id = input.ReadInt64();
            break;
          }
          case 50: {
            TopicConstantParent = input.ReadString();
            break;
          }
          case 58: {
            path_.AddEntriesFrom(input, _repeated_path_codec);
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
            ResourceName = input.ReadString();
            break;
          }
          case 40: {
            Id = input.ReadInt64();
            break;
          }
          case 50: {
            TopicConstantParent = input.ReadString();
            break;
          }
          case 58: {
            path_.AddEntriesFrom(ref input, _repeated_path_codec);
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
