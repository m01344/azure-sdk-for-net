// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Developer.DevCenter.Models
{
    public readonly partial struct StopOnDisconnectEnableStatus : IEquatable<StopOnDisconnectEnableStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StopOnDisconnectEnableStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StopOnDisconnectEnableStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Stop on disconnect is enabled on the Dev Box. </summary>
        public static StopOnDisconnectEnableStatus Enabled { get; } = new StopOnDisconnectEnableStatus(EnabledValue);
        /// <summary> Stop on disconnect is not enabled on the Dev Box. </summary>
        public static StopOnDisconnectEnableStatus Disabled { get; } = new StopOnDisconnectEnableStatus(DisabledValue);
        /// <summary> Determines if two <see cref="StopOnDisconnectEnableStatus"/> values are the same. </summary>
        public static bool operator ==(StopOnDisconnectEnableStatus left, StopOnDisconnectEnableStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StopOnDisconnectEnableStatus"/> values are not the same. </summary>
        public static bool operator !=(StopOnDisconnectEnableStatus left, StopOnDisconnectEnableStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StopOnDisconnectEnableStatus"/>. </summary>
        public static implicit operator StopOnDisconnectEnableStatus(string value) => new StopOnDisconnectEnableStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StopOnDisconnectEnableStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StopOnDisconnectEnableStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
