// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Generator.Tests.Generated
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BuildingHasAddressRelationshipAddressType
    {
        [EnumMember(Value = "Mailing"), Display(Name = "Mailing"), SourceValue(Value = "1")]
        Mailing,
        [EnumMember(Value = "Street"), Display(Name = "Street"), SourceValue(Value = "2")]
        Street,
        [EnumMember(Value = "Temporary"), Display(Name = "Temporary"), SourceValue(Value = "3")]
        Temporary
    }
}