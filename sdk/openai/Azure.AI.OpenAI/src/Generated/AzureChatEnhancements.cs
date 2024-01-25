// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.OpenAI
{
    /// <summary>
    /// Represents the output results of Azure enhancements to chat completions, as configured via the matching input provided
    /// in the request.
    /// </summary>
    public partial class AzureChatEnhancements
    {
        /// <summary> Initializes a new instance of <see cref="AzureChatEnhancements"/>. </summary>
        internal AzureChatEnhancements()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AzureChatEnhancements"/>. </summary>
        /// <param name="grounding"> The grounding enhancement that returns the bounding box of the objects detected in the image. </param>
        internal AzureChatEnhancements(AzureGroundingEnhancement grounding)
        {
            Grounding = grounding;
        }

        /// <summary> The grounding enhancement that returns the bounding box of the objects detected in the image. </summary>
        public AzureGroundingEnhancement Grounding { get; }
    }
}
