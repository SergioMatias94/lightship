// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: argeo/ardk-next/common/protos/ar_common_metadata.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Niantic.Protobuf;
using pbc = global::Niantic.Protobuf.Collections;
using pbr = global::Niantic.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Niantic.ARDK.AR.Protobuf {

  /// <summary>Holder for reflection information generated from argeo/ardk-next/common/protos/ar_common_metadata.proto</summary>
  public static partial class ArCommonMetadataReflection {

    #region Descriptor
    /// <summary>File descriptor for argeo/ardk-next/common/protos/ar_common_metadata.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ArCommonMetadataReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZhcmdlby9hcmRrLW5leHQvY29tbW9uL3Byb3Rvcy9hcl9jb21tb25fbWV0",
            "YWRhdGEucHJvdG8SDW5hci50ZWxlbWV0cnki6AIKEEFSQ29tbW9uTWV0YWRh",
            "dGESJQoOYXBwbGljYXRpb25faWQYASABKAlSDWFwcGxpY2F0aW9uSWQSGgoI",
            "cGxhdGZvcm0YAiABKAlSCHBsYXRmb3JtEiIKDG1hbnVmYWN0dXJlchgDIAEo",
            "CVIMbWFudWZhY3R1cmVyEiEKDGRldmljZV9tb2RlbBgEIAEoCVILZGV2aWNl",
            "TW9kZWwSFwoHdXNlcl9pZBgFIAEoCVIGdXNlcklkEhsKCWNsaWVudF9pZBgG",
            "IAEoCVIIY2xpZW50SWQSIQoMZGV2ZWxvcGVyX2lkGAcgASgJUgtkZXZlbG9w",
            "ZXJJZBIhCgxhcmRrX3ZlcnNpb24YCCABKAlSC2FyZGtWZXJzaW9uEi8KFGFy",
            "ZGtfYXBwX2luc3RhbmNlX2lkGAkgASgJUhFhcmRrQXBwSW5zdGFuY2VJZBId",
            "CgpyZXF1ZXN0X2lkGAogASgJUglyZXF1ZXN0SWRCVgohY29tLm5pYW50aWNw",
            "cm9qZWN0LmFyZGsudGVsZW1ldHJ5WhZuaWFudGljL2FyZGsvdGVsZW1ldHJ5",
            "qgIYTmlhbnRpYy5BUkRLLkFSLlByb3RvYnVmYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Niantic.ARDK.AR.Protobuf.ARCommonMetadata), global::Niantic.ARDK.AR.Protobuf.ARCommonMetadata.Parser, new[]{ "ApplicationId", "Platform", "Manufacturer", "DeviceModel", "UserId", "ClientId", "DeveloperId", "ArdkVersion", "ArdkAppInstanceId", "RequestId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ARCommonMetadata : pb::IMessage<ARCommonMetadata>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ARCommonMetadata> _parser = new pb::MessageParser<ARCommonMetadata>(() => new ARCommonMetadata());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ARCommonMetadata> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Niantic.ARDK.AR.Protobuf.ArCommonMetadataReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ARCommonMetadata() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ARCommonMetadata(ARCommonMetadata other) : this() {
      applicationId_ = other.applicationId_;
      platform_ = other.platform_;
      manufacturer_ = other.manufacturer_;
      deviceModel_ = other.deviceModel_;
      userId_ = other.userId_;
      clientId_ = other.clientId_;
      developerId_ = other.developerId_;
      ardkVersion_ = other.ardkVersion_;
      ardkAppInstanceId_ = other.ardkAppInstanceId_;
      requestId_ = other.requestId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ARCommonMetadata Clone() {
      return new ARCommonMetadata(this);
    }

    /// <summary>Field number for the "application_id" field.</summary>
    public const int ApplicationIdFieldNumber = 1;
    private string applicationId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ApplicationId {
      get { return applicationId_; }
      set {
        applicationId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "platform" field.</summary>
    public const int PlatformFieldNumber = 2;
    private string platform_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Platform {
      get { return platform_; }
      set {
        platform_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "manufacturer" field.</summary>
    public const int ManufacturerFieldNumber = 3;
    private string manufacturer_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Manufacturer {
      get { return manufacturer_; }
      set {
        manufacturer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "device_model" field.</summary>
    public const int DeviceModelFieldNumber = 4;
    private string deviceModel_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DeviceModel {
      get { return deviceModel_; }
      set {
        deviceModel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "user_id" field.</summary>
    public const int UserIdFieldNumber = 5;
    private string userId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "client_id" field.</summary>
    public const int ClientIdFieldNumber = 6;
    private string clientId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ClientId {
      get { return clientId_; }
      set {
        clientId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "developer_id" field.</summary>
    public const int DeveloperIdFieldNumber = 7;
    private string developerId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DeveloperId {
      get { return developerId_; }
      set {
        developerId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ardk_version" field.</summary>
    public const int ArdkVersionFieldNumber = 8;
    private string ardkVersion_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ArdkVersion {
      get { return ardkVersion_; }
      set {
        ardkVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "ardk_app_instance_id" field.</summary>
    public const int ArdkAppInstanceIdFieldNumber = 9;
    private string ardkAppInstanceId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ArdkAppInstanceId {
      get { return ardkAppInstanceId_; }
      set {
        ardkAppInstanceId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "request_id" field.</summary>
    public const int RequestIdFieldNumber = 10;
    private string requestId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RequestId {
      get { return requestId_; }
      set {
        requestId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ARCommonMetadata);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ARCommonMetadata other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ApplicationId != other.ApplicationId) return false;
      if (Platform != other.Platform) return false;
      if (Manufacturer != other.Manufacturer) return false;
      if (DeviceModel != other.DeviceModel) return false;
      if (UserId != other.UserId) return false;
      if (ClientId != other.ClientId) return false;
      if (DeveloperId != other.DeveloperId) return false;
      if (ArdkVersion != other.ArdkVersion) return false;
      if (ArdkAppInstanceId != other.ArdkAppInstanceId) return false;
      if (RequestId != other.RequestId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ApplicationId.Length != 0) hash ^= ApplicationId.GetHashCode();
      if (Platform.Length != 0) hash ^= Platform.GetHashCode();
      if (Manufacturer.Length != 0) hash ^= Manufacturer.GetHashCode();
      if (DeviceModel.Length != 0) hash ^= DeviceModel.GetHashCode();
      if (UserId.Length != 0) hash ^= UserId.GetHashCode();
      if (ClientId.Length != 0) hash ^= ClientId.GetHashCode();
      if (DeveloperId.Length != 0) hash ^= DeveloperId.GetHashCode();
      if (ArdkVersion.Length != 0) hash ^= ArdkVersion.GetHashCode();
      if (ArdkAppInstanceId.Length != 0) hash ^= ArdkAppInstanceId.GetHashCode();
      if (RequestId.Length != 0) hash ^= RequestId.GetHashCode();
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
      if (ApplicationId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ApplicationId);
      }
      if (Platform.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Platform);
      }
      if (Manufacturer.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Manufacturer);
      }
      if (DeviceModel.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DeviceModel);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(UserId);
      }
      if (ClientId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ClientId);
      }
      if (DeveloperId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DeveloperId);
      }
      if (ArdkVersion.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(ArdkVersion);
      }
      if (ArdkAppInstanceId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(ArdkAppInstanceId);
      }
      if (RequestId.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(RequestId);
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
      if (ApplicationId.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ApplicationId);
      }
      if (Platform.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Platform);
      }
      if (Manufacturer.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Manufacturer);
      }
      if (DeviceModel.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(DeviceModel);
      }
      if (UserId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(UserId);
      }
      if (ClientId.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ClientId);
      }
      if (DeveloperId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DeveloperId);
      }
      if (ArdkVersion.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(ArdkVersion);
      }
      if (ArdkAppInstanceId.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(ArdkAppInstanceId);
      }
      if (RequestId.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(RequestId);
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
      if (ApplicationId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ApplicationId);
      }
      if (Platform.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Platform);
      }
      if (Manufacturer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Manufacturer);
      }
      if (DeviceModel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceModel);
      }
      if (UserId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserId);
      }
      if (ClientId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ClientId);
      }
      if (DeveloperId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DeveloperId);
      }
      if (ArdkVersion.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ArdkVersion);
      }
      if (ArdkAppInstanceId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ArdkAppInstanceId);
      }
      if (RequestId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RequestId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ARCommonMetadata other) {
      if (other == null) {
        return;
      }
      if (other.ApplicationId.Length != 0) {
        ApplicationId = other.ApplicationId;
      }
      if (other.Platform.Length != 0) {
        Platform = other.Platform;
      }
      if (other.Manufacturer.Length != 0) {
        Manufacturer = other.Manufacturer;
      }
      if (other.DeviceModel.Length != 0) {
        DeviceModel = other.DeviceModel;
      }
      if (other.UserId.Length != 0) {
        UserId = other.UserId;
      }
      if (other.ClientId.Length != 0) {
        ClientId = other.ClientId;
      }
      if (other.DeveloperId.Length != 0) {
        DeveloperId = other.DeveloperId;
      }
      if (other.ArdkVersion.Length != 0) {
        ArdkVersion = other.ArdkVersion;
      }
      if (other.ArdkAppInstanceId.Length != 0) {
        ArdkAppInstanceId = other.ArdkAppInstanceId;
      }
      if (other.RequestId.Length != 0) {
        RequestId = other.RequestId;
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
            ApplicationId = input.ReadString();
            break;
          }
          case 18: {
            Platform = input.ReadString();
            break;
          }
          case 26: {
            Manufacturer = input.ReadString();
            break;
          }
          case 34: {
            DeviceModel = input.ReadString();
            break;
          }
          case 42: {
            UserId = input.ReadString();
            break;
          }
          case 50: {
            ClientId = input.ReadString();
            break;
          }
          case 58: {
            DeveloperId = input.ReadString();
            break;
          }
          case 66: {
            ArdkVersion = input.ReadString();
            break;
          }
          case 74: {
            ArdkAppInstanceId = input.ReadString();
            break;
          }
          case 82: {
            RequestId = input.ReadString();
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
            ApplicationId = input.ReadString();
            break;
          }
          case 18: {
            Platform = input.ReadString();
            break;
          }
          case 26: {
            Manufacturer = input.ReadString();
            break;
          }
          case 34: {
            DeviceModel = input.ReadString();
            break;
          }
          case 42: {
            UserId = input.ReadString();
            break;
          }
          case 50: {
            ClientId = input.ReadString();
            break;
          }
          case 58: {
            DeveloperId = input.ReadString();
            break;
          }
          case 66: {
            ArdkVersion = input.ReadString();
            break;
          }
          case 74: {
            ArdkAppInstanceId = input.ReadString();
            break;
          }
          case 82: {
            RequestId = input.ReadString();
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
