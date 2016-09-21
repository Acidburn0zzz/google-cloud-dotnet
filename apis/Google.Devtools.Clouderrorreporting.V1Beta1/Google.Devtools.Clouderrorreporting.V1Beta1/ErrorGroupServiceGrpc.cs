// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/devtools/clouderrorreporting/v1beta1/error_group_service.proto
// Original file comments:
// Copyright 2016 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;

namespace Google.Devtools.Clouderrorreporting.V1Beta1 {
  /// <summary>
  ///  Service for retrieving and updating individual error groups.
  /// </summary>
  public static class ErrorGroupService
  {
    static readonly string __ServiceName = "google.devtools.clouderrorreporting.v1beta1.ErrorGroupService";

    static readonly Marshaller<global::Google.Devtools.Clouderrorreporting.V1Beta1.GetGroupRequest> __Marshaller_GetGroupRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Devtools.Clouderrorreporting.V1Beta1.GetGroupRequest.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup> __Marshaller_ErrorGroup = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup.Parser.ParseFrom);
    static readonly Marshaller<global::Google.Devtools.Clouderrorreporting.V1Beta1.UpdateGroupRequest> __Marshaller_UpdateGroupRequest = Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Devtools.Clouderrorreporting.V1Beta1.UpdateGroupRequest.Parser.ParseFrom);

    static readonly Method<global::Google.Devtools.Clouderrorreporting.V1Beta1.GetGroupRequest, global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup> __Method_GetGroup = new Method<global::Google.Devtools.Clouderrorreporting.V1Beta1.GetGroupRequest, global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup>(
        MethodType.Unary,
        __ServiceName,
        "GetGroup",
        __Marshaller_GetGroupRequest,
        __Marshaller_ErrorGroup);

    static readonly Method<global::Google.Devtools.Clouderrorreporting.V1Beta1.UpdateGroupRequest, global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup> __Method_UpdateGroup = new Method<global::Google.Devtools.Clouderrorreporting.V1Beta1.UpdateGroupRequest, global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup>(
        MethodType.Unary,
        __ServiceName,
        "UpdateGroup",
        __Marshaller_UpdateGroupRequest,
        __Marshaller_ErrorGroup);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroupServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ErrorGroupService</summary>
    public abstract class ErrorGroupServiceBase
    {
      /// <summary>
      ///  Get the specified group.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup> GetGroup(global::Google.Devtools.Clouderrorreporting.V1Beta1.GetGroupRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

      /// <summary>
      ///  Replace the data for the specified group.
      ///  Fails if the group does not exist.
      /// </summary>
      public virtual global::System.Threading.Tasks.Task<global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup> UpdateGroup(global::Google.Devtools.Clouderrorreporting.V1Beta1.UpdateGroupRequest request, ServerCallContext context)
      {
        throw new RpcException(new Status(StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ErrorGroupService</summary>
    public class ErrorGroupServiceClient : ClientBase<ErrorGroupServiceClient>
    {
      /// <summary>Creates a new client for ErrorGroupService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ErrorGroupServiceClient(Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ErrorGroupService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ErrorGroupServiceClient(CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ErrorGroupServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ErrorGroupServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      ///  Get the specified group.
      /// </summary>
      public virtual global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup GetGroup(global::Google.Devtools.Clouderrorreporting.V1Beta1.GetGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetGroup(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Get the specified group.
      /// </summary>
      public virtual global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup GetGroup(global::Google.Devtools.Clouderrorreporting.V1Beta1.GetGroupRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetGroup, null, options, request);
      }
      /// <summary>
      ///  Get the specified group.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup> GetGroupAsync(global::Google.Devtools.Clouderrorreporting.V1Beta1.GetGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return GetGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Get the specified group.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup> GetGroupAsync(global::Google.Devtools.Clouderrorreporting.V1Beta1.GetGroupRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetGroup, null, options, request);
      }
      /// <summary>
      ///  Replace the data for the specified group.
      ///  Fails if the group does not exist.
      /// </summary>
      public virtual global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup UpdateGroup(global::Google.Devtools.Clouderrorreporting.V1Beta1.UpdateGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateGroup(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Replace the data for the specified group.
      ///  Fails if the group does not exist.
      /// </summary>
      public virtual global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup UpdateGroup(global::Google.Devtools.Clouderrorreporting.V1Beta1.UpdateGroupRequest request, CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateGroup, null, options, request);
      }
      /// <summary>
      ///  Replace the data for the specified group.
      ///  Fails if the group does not exist.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup> UpdateGroupAsync(global::Google.Devtools.Clouderrorreporting.V1Beta1.UpdateGroupRequest request, Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpdateGroupAsync(request, new CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      ///  Replace the data for the specified group.
      ///  Fails if the group does not exist.
      /// </summary>
      public virtual AsyncUnaryCall<global::Google.Devtools.Clouderrorreporting.V1Beta1.ErrorGroup> UpdateGroupAsync(global::Google.Devtools.Clouderrorreporting.V1Beta1.UpdateGroupRequest request, CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateGroup, null, options, request);
      }
      protected override ErrorGroupServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ErrorGroupServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    public static ServerServiceDefinition BindService(ErrorGroupServiceBase serviceImpl)
    {
      return ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetGroup, serviceImpl.GetGroup)
          .AddMethod(__Method_UpdateGroup, serviceImpl.UpdateGroup).Build();
    }

  }
}
#endregion
