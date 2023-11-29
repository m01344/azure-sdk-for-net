// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Contains the tables, columns &amp; rows resulting from a query. </summary>
    public partial class LogsQueryResult
    {
        /// <summary> Initializes a new instance of <see cref="LogsQueryResult"/>. </summary>
        /// <param name="allTables"> The list of tables, columns and rows. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allTables"/> is null. </exception>
        internal LogsQueryResult(IEnumerable<LogsTable> allTables)
        {
            Argument.AssertNotNull(allTables, nameof(allTables));

            AllTables = allTables.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="LogsQueryResult"/>. </summary>
        /// <param name="allTables"> The list of tables, columns and rows. </param>
        /// <param name="statistics"> Any object. </param>
        /// <param name="visualization"> Any object. </param>
        /// <param name="error"> Any object. </param>
        internal LogsQueryResult(IReadOnlyList<LogsTable> allTables, JsonElement statistics, JsonElement visualization, JsonElement error)
        {
            AllTables = allTables;
            _statistics = statistics;
            _visualization = visualization;
            _error = error;
        }
    }
}
