// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningJobResourceConfiguration. </summary>
    public partial class MachineLearningJobResourceConfiguration : MachineLearningResourceConfiguration
    {
        /// <summary> Initializes a new instance of MachineLearningJobResourceConfiguration. </summary>
        public MachineLearningJobResourceConfiguration()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningJobResourceConfiguration. </summary>
        /// <param name="instanceCount"> Optional number of instances or nodes used by the compute target. </param>
        /// <param name="instanceType"> Optional type of VM used as supported by the compute target. </param>
        /// <param name="locations"> Locations where the job can run. </param>
        /// <param name="maxInstanceCount">
        /// Optional max allowed number of instances or nodes to be used by the compute target.
        /// For use with elastic training, currently supported by PyTorch distribution type only.
        /// </param>
        /// <param name="properties"> Additional properties bag. </param>
        /// <param name="dockerArgs"> Extra arguments to pass to the Docker run command. This would override any parameters that have already been set by the system, or in this section. This parameter is only supported for Azure ML compute types. </param>
        /// <param name="shmSize"> Size of the docker container's shared memory block. This should be in the format of (number)(unit) where number as to be greater than 0 and the unit can be one of b(bytes), k(kilobytes), m(megabytes), or g(gigabytes). </param>
        internal MachineLearningJobResourceConfiguration(int? instanceCount, string instanceType, IList<string> locations, int? maxInstanceCount, IDictionary<string, BinaryData> properties, string dockerArgs, string shmSize) : base(instanceCount, instanceType, locations, maxInstanceCount, properties)
        {
            DockerArgs = dockerArgs;
            ShmSize = shmSize;
        }

        /// <summary> Extra arguments to pass to the Docker run command. This would override any parameters that have already been set by the system, or in this section. This parameter is only supported for Azure ML compute types. </summary>
        public string DockerArgs { get; set; }
        /// <summary> Size of the docker container's shared memory block. This should be in the format of (number)(unit) where number as to be greater than 0 and the unit can be one of b(bytes), k(kilobytes), m(megabytes), or g(gigabytes). </summary>
        public string ShmSize { get; set; }
    }
}
