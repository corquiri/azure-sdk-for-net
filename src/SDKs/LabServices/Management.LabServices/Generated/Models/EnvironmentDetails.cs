// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.LabServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This represents the details about a User's environment and its state.
    /// </summary>
    public partial class EnvironmentDetails
    {
        /// <summary>
        /// Initializes a new instance of the EnvironmentDetails class.
        /// </summary>
        public EnvironmentDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EnvironmentDetails class.
        /// </summary>
        /// <param name="name">Name of the Environment</param>
        /// <param name="description">Description of the Environment</param>
        /// <param name="id">Resource Id of the environment</param>
        /// <param name="provisioningState">The provisioning state of the
        /// environment. This also includes LabIsFull and NotYetProvisioned
        /// status.</param>
        /// <param name="virtualMachineDetails">Details of backing DTL virtual
        /// machine with compute and network details.</param>
        /// <param name="latestOperationResult">The details of the latest
        /// operation. ex: status, error</param>
        /// <param name="environmentState">Publishing state of the environment
        /// setting Possible values are Creating, Created, Failed</param>
        /// <param name="totalUsage">How long the environment has been used by
        /// a lab user</param>
        /// <param name="passwordLastReset">When the password was last reset on
        /// the environment.</param>
        public EnvironmentDetails(string name = default(string), string description = default(string), string id = default(string), string provisioningState = default(string), VirtualMachineDetails virtualMachineDetails = default(VirtualMachineDetails), LatestOperationResult latestOperationResult = default(LatestOperationResult), string environmentState = default(string), System.TimeSpan? totalUsage = default(System.TimeSpan?), System.DateTime? passwordLastReset = default(System.DateTime?))
        {
            Name = name;
            Description = description;
            Id = id;
            ProvisioningState = provisioningState;
            VirtualMachineDetails = virtualMachineDetails;
            LatestOperationResult = latestOperationResult;
            EnvironmentState = environmentState;
            TotalUsage = totalUsage;
            PasswordLastReset = passwordLastReset;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets name of the Environment
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets description of the Environment
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; private set; }

        /// <summary>
        /// Gets resource Id of the environment
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the environment. This also includes
        /// LabIsFull and NotYetProvisioned status.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets details of backing DTL virtual machine with compute and
        /// network details.
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachineDetails")]
        public VirtualMachineDetails VirtualMachineDetails { get; private set; }

        /// <summary>
        /// Gets the details of the latest operation. ex: status, error
        /// </summary>
        [JsonProperty(PropertyName = "latestOperationResult")]
        public LatestOperationResult LatestOperationResult { get; private set; }

        /// <summary>
        /// Gets publishing state of the environment setting Possible values
        /// are Creating, Created, Failed
        /// </summary>
        [JsonProperty(PropertyName = "environmentState")]
        public string EnvironmentState { get; private set; }

        /// <summary>
        /// Gets how long the environment has been used by a lab user
        /// </summary>
        [JsonProperty(PropertyName = "totalUsage")]
        public System.TimeSpan? TotalUsage { get; private set; }

        /// <summary>
        /// Gets when the password was last reset on the environment.
        /// </summary>
        [JsonProperty(PropertyName = "passwordLastReset")]
        public System.DateTime? PasswordLastReset { get; private set; }

    }
}