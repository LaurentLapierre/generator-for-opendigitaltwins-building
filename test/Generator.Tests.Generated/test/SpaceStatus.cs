// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Generator.Tests.Generated
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SpaceStatus
    {
        [EnumMember(Value = "Active"), Display(Name = "Active", Description = "active"), SourceValue(Value = "1")]
        Active,
        [EnumMember(Value = "Inactive"), Display(Name = "Inactive", Description = "inactive"), SourceValue(Value = "2")]
        Inactive,
        [EnumMember(Value = "Pending"), Display(Name = "Pending", Description = "pending"), SourceValue(Value = "3")]
        Pending,
        [EnumMember(Value = "UnderConstruction"), Display(Name = "Under Construction", Description = "underConstruction"), SourceValue(Value = "4")]
        UnderConstruction
    }
}