﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace TuroApi.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class CodePageDataItem
    {
        /// <summary>
        /// Initializes a new instance of the CodePageDataItem class.
        /// </summary>
        public CodePageDataItem() { }

        /// <summary>
        /// Initializes a new instance of the CodePageDataItem class.
        /// </summary>
        public CodePageDataItem(int? mDataIndex = default(int?), int? mUiFamilyCodePage = default(int?), string mWebName = default(string), string mHeaderName = default(string), string mBodyName = default(string), int? mFlags = default(int?))
        {
            MDataIndex = mDataIndex;
            MUiFamilyCodePage = mUiFamilyCodePage;
            MWebName = mWebName;
            MHeaderName = mHeaderName;
            MBodyName = mBodyName;
            MFlags = mFlags;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "m_dataIndex")]
        public int? MDataIndex { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "m_uiFamilyCodePage")]
        public int? MUiFamilyCodePage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "m_webName")]
        public string MWebName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "m_headerName")]
        public string MHeaderName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "m_bodyName")]
        public string MBodyName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "m_flags")]
        public int? MFlags { get; set; }

    }
}
