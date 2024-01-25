// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Change directory result for reservation order or reservation. </summary>
    public partial class ChangeDirectoryResult
    {
        /// <summary> Initializes a new instance of <see cref="ChangeDirectoryResult"/>. </summary>
        internal ChangeDirectoryResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ChangeDirectoryResult"/>. </summary>
        /// <param name="id"> Identifier of the reservation order or reservation. </param>
        /// <param name="name"> Name of the reservation order or reservation. </param>
        /// <param name="isSucceeded"> True if change directory operation succeeded on this reservation order or reservation. </param>
        /// <param name="error"> Error reason if operation failed. Null otherwise. </param>
        internal ChangeDirectoryResult(Guid? id, string name, bool? isSucceeded, string error)
        {
            Id = id;
            Name = name;
            IsSucceeded = isSucceeded;
            Error = error;
        }

        /// <summary> Identifier of the reservation order or reservation. </summary>
        public Guid? Id { get; }
        /// <summary> Name of the reservation order or reservation. </summary>
        public string Name { get; }
        /// <summary> True if change directory operation succeeded on this reservation order or reservation. </summary>
        public bool? IsSucceeded { get; }
        /// <summary> Error reason if operation failed. Null otherwise. </summary>
        public string Error { get; }
    }
}
