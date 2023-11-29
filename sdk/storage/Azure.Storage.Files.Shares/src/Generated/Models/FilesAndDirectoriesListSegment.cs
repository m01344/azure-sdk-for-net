// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> Abstract for entries that can be listed from Directory. </summary>
    internal partial class FilesAndDirectoriesListSegment
    {
        /// <summary> Initializes a new instance of <see cref="FilesAndDirectoriesListSegment"/>. </summary>
        /// <param name="directoryItems"></param>
        /// <param name="fileItems"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="directoryItems"/> or <paramref name="fileItems"/> is null. </exception>
        internal FilesAndDirectoriesListSegment(IEnumerable<DirectoryItem> directoryItems, IEnumerable<FileItem> fileItems)
        {
            Argument.AssertNotNull(directoryItems, nameof(directoryItems));
            Argument.AssertNotNull(fileItems, nameof(fileItems));

            DirectoryItems = directoryItems.ToList();
            FileItems = fileItems.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="FilesAndDirectoriesListSegment"/>. </summary>
        /// <param name="directoryItems"></param>
        /// <param name="fileItems"></param>
        internal FilesAndDirectoriesListSegment(IReadOnlyList<DirectoryItem> directoryItems, IReadOnlyList<FileItem> fileItems)
        {
            DirectoryItems = directoryItems;
            FileItems = fileItems;
        }

        /// <summary> Gets the directory items. </summary>
        public IReadOnlyList<DirectoryItem> DirectoryItems { get; }
        /// <summary> Gets the file items. </summary>
        public IReadOnlyList<FileItem> FileItems { get; }
    }
}
