// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: validator_set.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Types {

  /// <summary>Holder for reflection information generated from validator_set.proto</summary>
  public static partial class ValidatorSetReflection {

    #region Descriptor
    /// <summary>File descriptor for validator_set.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ValidatorSetReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChN2YWxpZGF0b3Jfc2V0LnByb3RvEgV0eXBlcxobdmFsaWRhdG9yX3B1Ymxp",
            "Y19rZXlzLnByb3RvIkkKDFZhbGlkYXRvclNldBI5ChV2YWxpZGF0b3JfcHVi",
            "bGljX2tleXMYASADKAsyGi50eXBlcy5WYWxpZGF0b3JQdWJsaWNLZXlzYgZw",
            "cm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Types.ValidatorPublicKeysReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Types.ValidatorSet), global::Types.ValidatorSet.Parser, new[]{ "ValidatorPublicKeys" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Protobuf definition for the Rust struct ValidatorSet.
  /// </summary>
  public sealed partial class ValidatorSet : pb::IMessage<ValidatorSet> {
    private static readonly pb::MessageParser<ValidatorSet> _parser = new pb::MessageParser<ValidatorSet>(() => new ValidatorSet());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ValidatorSet> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Types.ValidatorSetReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValidatorSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValidatorSet(ValidatorSet other) : this() {
      validatorPublicKeys_ = other.validatorPublicKeys_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValidatorSet Clone() {
      return new ValidatorSet(this);
    }

    /// <summary>Field number for the "validator_public_keys" field.</summary>
    public const int ValidatorPublicKeysFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Types.ValidatorPublicKeys> _repeated_validatorPublicKeys_codec
        = pb::FieldCodec.ForMessage(10, global::Types.ValidatorPublicKeys.Parser);
    private readonly pbc::RepeatedField<global::Types.ValidatorPublicKeys> validatorPublicKeys_ = new pbc::RepeatedField<global::Types.ValidatorPublicKeys>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Types.ValidatorPublicKeys> ValidatorPublicKeys {
      get { return validatorPublicKeys_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ValidatorSet);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ValidatorSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!validatorPublicKeys_.Equals(other.validatorPublicKeys_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= validatorPublicKeys_.GetHashCode();
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
      validatorPublicKeys_.WriteTo(output, _repeated_validatorPublicKeys_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += validatorPublicKeys_.CalculateSize(_repeated_validatorPublicKeys_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ValidatorSet other) {
      if (other == null) {
        return;
      }
      validatorPublicKeys_.Add(other.validatorPublicKeys_);
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
            validatorPublicKeys_.AddEntriesFrom(input, _repeated_validatorPublicKeys_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
