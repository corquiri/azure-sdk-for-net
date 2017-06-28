// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A2A specific policy details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("A2A")]
    public partial class A2APolicyDetails : PolicyProviderSpecificDetails
    {
        /// <summary>
        /// Initializes a new instance of the A2APolicyDetails class.
        /// </summary>
        public A2APolicyDetails()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the A2APolicyDetails class.
        /// </summary>
        /// <param name="recoveryPointThresholdInMinutes">The recovery point
        /// threshold in minutes.</param>
        /// <param name="recoveryPointHistory">The duration in minutes until
        /// which the recovery points need to be
        /// stored.</param>
        /// <param name="appConsistentFrequencyInMinutes">The app consistent
        /// snapshot frequency in minutes.</param>
        /// <param name="multiVmSyncStatus">A value indicating whether multi-VM
        /// sync has to be enabled.</param>
        /// <param name="crashConsistentFrequencyInMinutes">The crash
        /// consistent snapshot frequency in minutes.</param>
        public A2APolicyDetails(int? recoveryPointThresholdInMinutes = default(int?), int? recoveryPointHistory = default(int?), int? appConsistentFrequencyInMinutes = default(int?), string multiVmSyncStatus = default(string), int? crashConsistentFrequencyInMinutes = default(int?))
        {
            RecoveryPointThresholdInMinutes = recoveryPointThresholdInMinutes;
            RecoveryPointHistory = recoveryPointHistory;
            AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
            MultiVmSyncStatus = multiVmSyncStatus;
            CrashConsistentFrequencyInMinutes = crashConsistentFrequencyInMinutes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the recovery point threshold in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointThresholdInMinutes")]
        public int? RecoveryPointThresholdInMinutes { get; set; }

        /// <summary>
        /// Gets or sets the duration in minutes until which the recovery
        /// points need to be
        /// stored.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryPointHistory")]
        public int? RecoveryPointHistory { get; set; }

        /// <summary>
        /// Gets or sets the app consistent snapshot frequency in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "appConsistentFrequencyInMinutes")]
        public int? AppConsistentFrequencyInMinutes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether multi-VM sync has to be
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmSyncStatus")]
        public string MultiVmSyncStatus { get; set; }

        /// <summary>
        /// Gets or sets the crash consistent snapshot frequency in minutes.
        /// </summary>
        [JsonProperty(PropertyName = "crashConsistentFrequencyInMinutes")]
        public int? CrashConsistentFrequencyInMinutes { get; set; }

    }
}