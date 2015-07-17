// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using Microsoft.Azure;
using Microsoft.WindowsAzure.Management.Compute;
using Microsoft.WindowsAzure.Management.Compute.Models;
using System;
using System.Management.Automation;

namespace Microsoft.WindowsAzure.Commands.Compute.Automation
{
    [Cmdlet(VerbsLifecycle.Invoke, "AzureVirtualMachineShutdownMethod")]
    [OutputType(typeof(OperationStatusResponse))]
    public class InvokeAzureVirtualMachineShutdownMethod : ComputeAutomationBaseCmdlet
    {
        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string ServiceName { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = true)]
        public string DeploymentName { get; set; }

        [Parameter(Mandatory = true)]
        public string VirtualMachineName { get; set; }

        [Parameter(Mandatory = true)]
        public VirtualMachineShutdownParameters Parameters { get; set; }

        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                var result = VirtualMachineClient.Shutdown(ServiceName, DeploymentName, VirtualMachineName, Parameters);
                WriteObject(result);
            });
        }
    }

    public partial class InvokeAzureComputeMethodCmdlet : ComputeAutomationBaseCmdlet
    {
        protected void ExecuteVirtualMachineShutdownMethod(object[] invokeMethodInputParameters)
        {
            string serviceName = (string)invokeMethodInputParameters[0];
            string deploymentName = (string)invokeMethodInputParameters[1];
            string virtualMachineName = (string)invokeMethodInputParameters[2];
            VirtualMachineShutdownParameters parameters = (VirtualMachineShutdownParameters)invokeMethodInputParameters[3];

            var result = VirtualMachineClient.Shutdown(serviceName, deploymentName, virtualMachineName, parameters);
            WriteObject(result);
        }
    }}
