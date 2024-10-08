// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Monitoring target definition. </summary>
    public partial class MonitoringTarget
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MonitoringTarget"/>. </summary>
        /// <param name="taskType"> [Required] The machine learning task type of the monitored model. </param>
        public MonitoringTarget(ModelTaskType taskType)
        {
            TaskType = taskType;
        }

        /// <summary> Initializes a new instance of <see cref="MonitoringTarget"/>. </summary>
        /// <param name="deploymentId"> Reference to the deployment asset targeted by this monitor. </param>
        /// <param name="modelId"> Reference to the model asset targeted by this monitor. </param>
        /// <param name="taskType"> [Required] The machine learning task type of the monitored model. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MonitoringTarget(string deploymentId, string modelId, ModelTaskType taskType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DeploymentId = deploymentId;
            ModelId = modelId;
            TaskType = taskType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MonitoringTarget"/> for deserialization. </summary>
        internal MonitoringTarget()
        {
        }

        /// <summary> Reference to the deployment asset targeted by this monitor. </summary>
        public string DeploymentId { get; set; }
        /// <summary> Reference to the model asset targeted by this monitor. </summary>
        public string ModelId { get; set; }
        /// <summary> [Required] The machine learning task type of the monitored model. </summary>
        public ModelTaskType TaskType { get; set; }
    }
}
