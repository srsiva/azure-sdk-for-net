// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// The List data factory linkedServices operation response.
    /// </summary>
    public partial class LinkedServiceListResponse : AzureOperationResponse
    {
        private IList<LinkedService> _linkedServices;
        
        /// <summary>
        /// Optional. All the data factory linkedService instances.
        /// </summary>
        public IList<LinkedService> LinkedServices
        {
            get { return this._linkedServices; }
            set { this._linkedServices = value; }
        }
        
        private string _nextLink;
        
        /// <summary>
        /// Required. The link (url) to the next page of results.
        /// </summary>
        public string NextLink
        {
            get { return this._nextLink; }
            set { this._nextLink = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the LinkedServiceListResponse class.
        /// </summary>
        public LinkedServiceListResponse()
        {
            this.LinkedServices = new LazyList<LinkedService>();
        }
        
        /// <summary>
        /// Initializes a new instance of the LinkedServiceListResponse class
        /// with required arguments.
        /// </summary>
        public LinkedServiceListResponse(string nextLink)
            : this()
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException("nextLink");
            }
            this.NextLink = nextLink;
        }
    }
}
