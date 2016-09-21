// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/monitoring/v3/group.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Monitoring.V3 {

  /// <summary>Holder for reflection information generated from google/monitoring/v3/group.proto</summary>
  public static partial class GroupReflection {

    #region Descriptor
    /// <summary>File descriptor for google/monitoring/v3/group.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GroupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBnb29nbGUvbW9uaXRvcmluZy92My9ncm91cC5wcm90bxIUZ29vZ2xlLm1v",
            "bml0b3JpbmcudjMiZAoFR3JvdXASDAoEbmFtZRgBIAEoCRIUCgxkaXNwbGF5",
            "X25hbWUYAiABKAkSEwoLcGFyZW50X25hbWUYAyABKAkSDgoGZmlsdGVyGAUg",
            "ASgJEhIKCmlzX2NsdXN0ZXIYBiABKAhCKAoYY29tLmdvb2dsZS5tb25pdG9y",
            "aW5nLnYzQgpHcm91cFByb3RvUAFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Monitoring.V3.Group), global::Google.Monitoring.V3.Group.Parser, new[]{ "Name", "DisplayName", "ParentName", "Filter", "IsCluster" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  The description of a dynamic collection of monitored resources. Each group
  ///  has a filter that is matched against monitored resources and their associated
  ///  metadata. If a group's filter matches an available monitored resource, then
  ///  that resource is a member of that group.  Groups can contain any number of
  ///  monitored resources, and each monitored resource can be a member of any
  ///  number of groups.
  ///
  ///  Groups can be nested in parent-child hierarchies. The `parentName` field
  ///  identifies an optional parent for each group.  If a group has a parent, then
  ///  the only monitored resources available to be matched by the group's filter
  ///  are the resources contained in the parent group.  In other words, a group
  ///  contains the monitored resources that match its filter and the filters of all
  ///  the group's ancestors.  A group without a parent can contain any monitored
  ///  resource.
  ///
  ///  For example, consider an infrastructure running a set of instances with two
  ///  user-defined tags: `"environment"` and `"role"`. A parent group has a filter,
  ///  `environment="production"`.  A child of that parent group has a filter,
  ///  `role="transcoder"`.  The parent group contains all instances in the
  ///  production environment, regardless of their roles.  The child group contains
  ///  instances that have the transcoder role *and* are in the production
  ///  environment.
  ///
  ///  The monitored resources contained in a group can change at any moment,
  ///  depending on what resources exist and what filters are associated with the
  ///  group and its ancestors.
  /// </summary>
  public sealed partial class Group : pb::IMessage<Group> {
    private static readonly pb::MessageParser<Group> _parser = new pb::MessageParser<Group>(() => new Group());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Group> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Monitoring.V3.GroupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Group() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Group(Group other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      parentName_ = other.parentName_;
      filter_ = other.filter_;
      isCluster_ = other.isCluster_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Group Clone() {
      return new Group(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    ///  The name of this group.
    ///  The format is
    ///  `"projects/{project_id_or_number}/groups/{group_id}"`.
    ///  When creating a group, this field is ignored and a new name is created
    ///  consisting of the project specified in the call to `CreateGroup`
    ///  and a unique `{group_id}` that is generated automatically.
    ///  @OutputOnly
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    ///  A user-assigned name for this group, used only for display purposes.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "parent_name" field.</summary>
    public const int ParentNameFieldNumber = 3;
    private string parentName_ = "";
    /// <summary>
    ///  The name of the group's parent, if it has one.
    ///  The format is `"projects/{project_id_or_number}/groups/{group_id}"`.
    ///  For groups with no parent, `parentName` is the empty string, `""`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ParentName {
      get { return parentName_; }
      set {
        parentName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 5;
    private string filter_ = "";
    /// <summary>
    ///  The filter used to determine which monitored resources belong to this group.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Filter {
      get { return filter_; }
      set {
        filter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_cluster" field.</summary>
    public const int IsClusterFieldNumber = 6;
    private bool isCluster_;
    /// <summary>
    ///  If true, the members of this group are considered to be a cluster.
    ///  The system can perform additional analysis on groups that are clusters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool IsCluster {
      get { return isCluster_; }
      set {
        isCluster_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Group);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Group other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (ParentName != other.ParentName) return false;
      if (Filter != other.Filter) return false;
      if (IsCluster != other.IsCluster) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (ParentName.Length != 0) hash ^= ParentName.GetHashCode();
      if (Filter.Length != 0) hash ^= Filter.GetHashCode();
      if (IsCluster != false) hash ^= IsCluster.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (ParentName.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(ParentName);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Filter);
      }
      if (IsCluster != false) {
        output.WriteRawTag(48);
        output.WriteBool(IsCluster);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (ParentName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ParentName);
      }
      if (Filter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
      }
      if (IsCluster != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Group other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.ParentName.Length != 0) {
        ParentName = other.ParentName;
      }
      if (other.Filter.Length != 0) {
        Filter = other.Filter;
      }
      if (other.IsCluster != false) {
        IsCluster = other.IsCluster;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 26: {
            ParentName = input.ReadString();
            break;
          }
          case 42: {
            Filter = input.ReadString();
            break;
          }
          case 48: {
            IsCluster = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
