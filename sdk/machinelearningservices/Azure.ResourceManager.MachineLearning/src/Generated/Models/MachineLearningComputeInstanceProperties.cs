// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Compute Instance properties. </summary>
    public partial class MachineLearningComputeInstanceProperties
    {
        /// <summary> Initializes a new instance of MachineLearningComputeInstanceProperties. </summary>
        public MachineLearningComputeInstanceProperties()
        {
            CustomServices = new ChangeTrackingList<CustomService>();
            Applications = new ChangeTrackingList<MachineLearningComputeInstanceApplication>();
            Errors = new ChangeTrackingList<MachineLearningError>();
            Containers = new ChangeTrackingList<MachineLearningComputeInstanceContainer>();
            DataDisks = new ChangeTrackingList<MachineLearningComputeInstanceDataDisk>();
            DataMounts = new ChangeTrackingList<MachineLearningComputeInstanceDataMount>();
        }

        /// <summary> Initializes a new instance of MachineLearningComputeInstanceProperties. </summary>
        /// <param name="vmSize"> Virtual Machine Size. </param>
        /// <param name="subnet"> Virtual network subnet resource ID the compute nodes belong to. </param>
        /// <param name="applicationSharingPolicy"> Policy for sharing applications on this compute instance among users of parent workspace. If Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access applications on this instance depending on his/her assigned role. </param>
        /// <param name="autologgerSettings"> Specifies settings for autologger. </param>
        /// <param name="sshSettings"> Specifies policy and settings for SSH access. </param>
        /// <param name="customServices"> List of Custom Services added to the compute. </param>
        /// <param name="osImageMetadata"> Returns metadata about the operating system image for this compute instance. </param>
        /// <param name="connectivityEndpoints"> Describes all connectivity endpoints available for this ComputeInstance. </param>
        /// <param name="applications"> Describes available applications and their endpoints on this ComputeInstance. </param>
        /// <param name="createdBy"> Describes information on user who created this ComputeInstance. </param>
        /// <param name="errors"> Collection of errors encountered on this ComputeInstance. </param>
        /// <param name="state"> The current state of this ComputeInstance. </param>
        /// <param name="computeInstanceAuthorizationType"> The Compute Instance Authorization type. Available values are personal (default). </param>
        /// <param name="personalComputeInstanceSettings"> Settings for a personal compute instance. </param>
        /// <param name="setupScriptsSettings"> Details of customized scripts to execute for setting up the cluster. </param>
        /// <param name="lastOperation"> The last operation on ComputeInstance. </param>
        /// <param name="schedules"> The list of schedules to be applied on the computes. </param>
        /// <param name="idleTimeBeforeShutdown"> Stops compute instance after user defined period of inactivity. Time is defined in ISO8601 format. Minimum is 15 min, maximum is 3 days. </param>
        /// <param name="enableNodePublicIP"> Enable or disable node public IP address provisioning. Possible values are: Possible values are: true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will have a private endpoint and no public IPs. </param>
        /// <param name="containers"> Describes informations of containers on this ComputeInstance. </param>
        /// <param name="dataDisks"> Describes informations of dataDisks on this ComputeInstance. </param>
        /// <param name="dataMounts"> Describes informations of dataMounts on this ComputeInstance. </param>
        /// <param name="versions"> ComputeInstance version. </param>
        internal MachineLearningComputeInstanceProperties(string vmSize, ResourceId subnet, MachineLearningApplicationSharingPolicy? applicationSharingPolicy, ComputeInstanceAutologgerSettings autologgerSettings, MachineLearningComputeInstanceSshSettings sshSettings, IList<CustomService> customServices, ImageMetadata osImageMetadata, MachineLearningComputeInstanceConnectivityEndpoints connectivityEndpoints, IReadOnlyList<MachineLearningComputeInstanceApplication> applications, MachineLearningComputeInstanceCreatedBy createdBy, IReadOnlyList<MachineLearningError> errors, MachineLearningComputeInstanceState? state, MachineLearningComputeInstanceAuthorizationType? computeInstanceAuthorizationType, PersonalComputeInstanceSettings personalComputeInstanceSettings, SetupScripts setupScriptsSettings, MachineLearningComputeInstanceLastOperation lastOperation, ComputeSchedules schedules, string idleTimeBeforeShutdown, bool? enableNodePublicIP, IReadOnlyList<MachineLearningComputeInstanceContainer> containers, IReadOnlyList<MachineLearningComputeInstanceDataDisk> dataDisks, IReadOnlyList<MachineLearningComputeInstanceDataMount> dataMounts, ComputeInstanceVersion versions)
        {
            VmSize = vmSize;
            Subnet = subnet;
            ApplicationSharingPolicy = applicationSharingPolicy;
            AutologgerSettings = autologgerSettings;
            SshSettings = sshSettings;
            CustomServices = customServices;
            OSImageMetadata = osImageMetadata;
            ConnectivityEndpoints = connectivityEndpoints;
            Applications = applications;
            CreatedBy = createdBy;
            Errors = errors;
            State = state;
            ComputeInstanceAuthorizationType = computeInstanceAuthorizationType;
            PersonalComputeInstanceSettings = personalComputeInstanceSettings;
            SetupScriptsSettings = setupScriptsSettings;
            LastOperation = lastOperation;
            Schedules = schedules;
            IdleTimeBeforeShutdown = idleTimeBeforeShutdown;
            EnableNodePublicIP = enableNodePublicIP;
            Containers = containers;
            DataDisks = dataDisks;
            DataMounts = dataMounts;
            Versions = versions;
        }

        /// <summary> Virtual Machine Size. </summary>
        public string VmSize { get; set; }
        /// <summary> Virtual network subnet resource ID the compute nodes belong to. </summary>
        internal ResourceId Subnet { get; set; }
        /// <summary> The ID of the resource. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set => Subnet = new ResourceId(value);
        }

        /// <summary> Policy for sharing applications on this compute instance among users of parent workspace. If Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access applications on this instance depending on his/her assigned role. </summary>
        public MachineLearningApplicationSharingPolicy? ApplicationSharingPolicy { get; set; }
        /// <summary> Specifies settings for autologger. </summary>
        internal ComputeInstanceAutologgerSettings AutologgerSettings { get; set; }
        /// <summary> Indicates whether mlflow autologger is enabled for notebooks. </summary>
        public MachineLearningFlowAutoLogger? MlflowAutologger
        {
            get => AutologgerSettings is null ? default : AutologgerSettings.MlflowAutologger;
            set
            {
                if (AutologgerSettings is null)
                    AutologgerSettings = new ComputeInstanceAutologgerSettings();
                AutologgerSettings.MlflowAutologger = value;
            }
        }

        /// <summary> Specifies policy and settings for SSH access. </summary>
        public MachineLearningComputeInstanceSshSettings SshSettings { get; set; }
        /// <summary> List of Custom Services added to the compute. </summary>
        public IList<CustomService> CustomServices { get; set; }
        /// <summary> Returns metadata about the operating system image for this compute instance. </summary>
        public ImageMetadata OSImageMetadata { get; }
        /// <summary> Describes all connectivity endpoints available for this ComputeInstance. </summary>
        public MachineLearningComputeInstanceConnectivityEndpoints ConnectivityEndpoints { get; }
        /// <summary> Describes available applications and their endpoints on this ComputeInstance. </summary>
        public IReadOnlyList<MachineLearningComputeInstanceApplication> Applications { get; }
        /// <summary> Describes information on user who created this ComputeInstance. </summary>
        public MachineLearningComputeInstanceCreatedBy CreatedBy { get; }
        /// <summary> Collection of errors encountered on this ComputeInstance. </summary>
        public IReadOnlyList<MachineLearningError> Errors { get; }
        /// <summary> The current state of this ComputeInstance. </summary>
        public MachineLearningComputeInstanceState? State { get; }
        /// <summary> The Compute Instance Authorization type. Available values are personal (default). </summary>
        public MachineLearningComputeInstanceAuthorizationType? ComputeInstanceAuthorizationType { get; set; }
        /// <summary> Settings for a personal compute instance. </summary>
        internal PersonalComputeInstanceSettings PersonalComputeInstanceSettings { get; set; }
        /// <summary> A user explicitly assigned to a personal compute instance. </summary>
        public MachineLearningComputeInstanceAssignedUser PersonalComputeInstanceAssignedUser
        {
            get => PersonalComputeInstanceSettings is null ? default : PersonalComputeInstanceSettings.AssignedUser;
            set
            {
                if (PersonalComputeInstanceSettings is null)
                    PersonalComputeInstanceSettings = new PersonalComputeInstanceSettings();
                PersonalComputeInstanceSettings.AssignedUser = value;
            }
        }

        /// <summary> Details of customized scripts to execute for setting up the cluster. </summary>
        internal SetupScripts SetupScriptsSettings { get; set; }
        /// <summary> Customized setup scripts. </summary>
        public MachineLearningScriptsToExecute Scripts
        {
            get => SetupScriptsSettings is null ? default : SetupScriptsSettings.Scripts;
            set
            {
                if (SetupScriptsSettings is null)
                    SetupScriptsSettings = new SetupScripts();
                SetupScriptsSettings.Scripts = value;
            }
        }

        /// <summary> The last operation on ComputeInstance. </summary>
        public MachineLearningComputeInstanceLastOperation LastOperation { get; }
        /// <summary> The list of schedules to be applied on the computes. </summary>
        internal ComputeSchedules Schedules { get; set; }
        /// <summary> The list of compute start stop schedules to be applied. </summary>
        public IReadOnlyList<MachineLearningComputeStartStopSchedule> SchedulesComputeStartStop
        {
            get
            {
                if (Schedules is null)
                    Schedules = new ComputeSchedules();
                return Schedules.ComputeStartStop;
            }
        }

        /// <summary> Stops compute instance after user defined period of inactivity. Time is defined in ISO8601 format. Minimum is 15 min, maximum is 3 days. </summary>
        public string IdleTimeBeforeShutdown { get; set; }
        /// <summary> Enable or disable node public IP address provisioning. Possible values are: Possible values are: true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will have a private endpoint and no public IPs. </summary>
        public bool? EnableNodePublicIP { get; set; }
        /// <summary> Describes informations of containers on this ComputeInstance. </summary>
        public IReadOnlyList<MachineLearningComputeInstanceContainer> Containers { get; }
        /// <summary> Describes informations of dataDisks on this ComputeInstance. </summary>
        public IReadOnlyList<MachineLearningComputeInstanceDataDisk> DataDisks { get; }
        /// <summary> Describes informations of dataMounts on this ComputeInstance. </summary>
        public IReadOnlyList<MachineLearningComputeInstanceDataMount> DataMounts { get; }
        /// <summary> ComputeInstance version. </summary>
        internal ComputeInstanceVersion Versions { get; }
        /// <summary> Runtime of compute instance. </summary>
        public string VersionsRuntime
        {
            get => Versions?.Runtime;
        }
    }
}
