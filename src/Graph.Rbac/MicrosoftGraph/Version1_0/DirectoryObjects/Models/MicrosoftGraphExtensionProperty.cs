// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Common.MSGraph.Version1_0.DirectoryObjects.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftGraphExtensionProperty : MicrosoftGraphDirectoryObject
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftGraphExtensionProperty
        /// class.
        /// </summary>
        public MicrosoftGraphExtensionProperty()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftGraphExtensionProperty
        /// class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="id">Read-only.</param>
        /// <param name="appDisplayName">Display name of the application object
        /// on which this extension property is defined. Read-only.</param>
        /// <param name="dataType">Specifies the data type of the value the
        /// extension property can hold. Following values are supported. Not
        /// nullable. Binary - 256 bytes maximumBooleanDateTime - Must be
        /// specified in ISO 8601 format. Will be stored in UTC.Integer -
        /// 32-bit value.LargeInteger - 64-bit value.String - 256 characters
        /// maximum</param>
        /// <param name="isSyncedFromOnPremises">Indicates if this extension
        /// property was sycned from onpremises directory using Azure AD
        /// Connect. Read-only.</param>
        /// <param name="name">Name of the extension property. Not
        /// nullable.</param>
        /// <param name="targetObjects">Following values are supported. Not
        /// nullable. UserGroupOrganizationDeviceApplication</param>
        public MicrosoftGraphExtensionProperty(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string id = default(string), string odatatype = default(string), System.DateTime? deletedDateTime = default(System.DateTime?), string appDisplayName = default(string), string dataType = default(string), bool? isSyncedFromOnPremises = default(bool?), string name = default(string), IList<string> targetObjects = default(IList<string>))
            : base(additionalProperties, id, odatatype, deletedDateTime)
        {
            AppDisplayName = appDisplayName;
            DataType = dataType;
            IsSyncedFromOnPremises = isSyncedFromOnPremises;
            Name = name;
            TargetObjects = targetObjects;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets display name of the application object on which this
        /// extension property is defined. Read-only.
        /// </summary>
        [JsonProperty(PropertyName = "appDisplayName")]
        public string AppDisplayName { get; set; }

        /// <summary>
        /// Gets or sets specifies the data type of the value the extension
        /// property can hold. Following values are supported. Not nullable.
        /// Binary - 256 bytes maximumBooleanDateTime - Must be specified in
        /// ISO 8601 format. Will be stored in UTC.Integer - 32-bit
        /// value.LargeInteger - 64-bit value.String - 256 characters maximum
        /// </summary>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets indicates if this extension property was sycned from
        /// onpremises directory using Azure AD Connect. Read-only.
        /// </summary>
        [JsonProperty(PropertyName = "isSyncedFromOnPremises")]
        public bool? IsSyncedFromOnPremises { get; set; }

        /// <summary>
        /// Gets or sets name of the extension property. Not nullable.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets following values are supported. Not nullable.
        /// UserGroupOrganizationDeviceApplication
        /// </summary>
        [JsonProperty(PropertyName = "targetObjects")]
        public IList<string> TargetObjects { get; set; }

    }
}