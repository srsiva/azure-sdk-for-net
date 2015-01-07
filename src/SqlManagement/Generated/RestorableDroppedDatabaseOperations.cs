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
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using Hyak.Common;
using Microsoft.WindowsAzure.Management.Sql;
using Microsoft.WindowsAzure.Management.Sql.Models;

namespace Microsoft.WindowsAzure.Management.Sql
{
    /// <summary>
    /// Contains operations for getting dropped Azure SQL Databases that can be
    /// restored.
    /// </summary>
    internal partial class RestorableDroppedDatabaseOperations : IServiceOperations<SqlManagementClient>, IRestorableDroppedDatabaseOperations
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RestorableDroppedDatabaseOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal RestorableDroppedDatabaseOperations(SqlManagementClient client)
        {
            this._client = client;
        }
        
        private SqlManagementClient _client;
        
        /// <summary>
        /// Gets a reference to the
        /// Microsoft.WindowsAzure.Management.Sql.SqlManagementClient.
        /// </summary>
        public SqlManagementClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// Returns information about a dropped Azure SQL Database that can be
        /// restored.
        /// </summary>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server on which the
        /// database was hosted.
        /// </param>
        /// <param name='entityId'>
        /// Required. The entity ID of the restorable dropped Azure SQL
        /// Database to be obtained.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Contains the response to the Get Restorable Dropped Database
        /// request.
        /// </returns>
        public async Task<RestorableDroppedDatabaseGetResponse> GetAsync(string serverName, string entityId, CancellationToken cancellationToken)
        {
            // Validate
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            if (entityId == null)
            {
                throw new ArgumentNullException("entityId");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serverName", serverName);
                tracingParameters.Add("entityId", entityId);
                TracingAdapter.Enter(invocationId, this, "GetAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/" + (this.Client.Credentials.SubscriptionId == null ? "" : Uri.EscapeDataString(this.Client.Credentials.SubscriptionId)) + "/services/sqlservers/servers/" + Uri.EscapeDataString(serverName) + "/restorabledroppeddatabases/" + Uri.EscapeDataString(entityId);
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2012-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    RestorableDroppedDatabaseGetResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new RestorableDroppedDatabaseGetResponse();
                        XDocument responseDoc = XDocument.Parse(responseContent);
                        
                        XElement serviceResourceElement = responseDoc.Element(XName.Get("ServiceResource", "http://schemas.microsoft.com/windowsazure"));
                        if (serviceResourceElement != null)
                        {
                            RestorableDroppedDatabase serviceResourceInstance = new RestorableDroppedDatabase();
                            result.Database = serviceResourceInstance;
                            
                            XElement entityIdElement = serviceResourceElement.Element(XName.Get("EntityId", "http://schemas.microsoft.com/windowsazure"));
                            if (entityIdElement != null)
                            {
                                string entityIdInstance = entityIdElement.Value;
                                serviceResourceInstance.EntityId = entityIdInstance;
                            }
                            
                            XElement serverNameElement = serviceResourceElement.Element(XName.Get("ServerName", "http://schemas.microsoft.com/windowsazure"));
                            if (serverNameElement != null)
                            {
                                string serverNameInstance = serverNameElement.Value;
                                serviceResourceInstance.ServerName = serverNameInstance;
                            }
                            
                            XElement editionElement = serviceResourceElement.Element(XName.Get("Edition", "http://schemas.microsoft.com/windowsazure"));
                            if (editionElement != null)
                            {
                                string editionInstance = editionElement.Value;
                                serviceResourceInstance.Edition = editionInstance;
                            }
                            
                            XElement maxSizeBytesElement = serviceResourceElement.Element(XName.Get("MaxSizeBytes", "http://schemas.microsoft.com/windowsazure"));
                            if (maxSizeBytesElement != null)
                            {
                                long maxSizeBytesInstance = long.Parse(maxSizeBytesElement.Value, CultureInfo.InvariantCulture);
                                serviceResourceInstance.MaximumDatabaseSizeInBytes = maxSizeBytesInstance;
                            }
                            
                            XElement creationDateElement = serviceResourceElement.Element(XName.Get("CreationDate", "http://schemas.microsoft.com/windowsazure"));
                            if (creationDateElement != null)
                            {
                                DateTime creationDateInstance = DateTime.Parse(creationDateElement.Value, CultureInfo.InvariantCulture);
                                serviceResourceInstance.CreationDate = creationDateInstance;
                            }
                            
                            XElement deletionDateElement = serviceResourceElement.Element(XName.Get("DeletionDate", "http://schemas.microsoft.com/windowsazure"));
                            if (deletionDateElement != null)
                            {
                                DateTime deletionDateInstance = DateTime.Parse(deletionDateElement.Value, CultureInfo.InvariantCulture);
                                serviceResourceInstance.DeletionDate = deletionDateInstance;
                            }
                            
                            XElement recoveryPeriodStartDateElement = serviceResourceElement.Element(XName.Get("RecoveryPeriodStartDate", "http://schemas.microsoft.com/windowsazure"));
                            if (recoveryPeriodStartDateElement != null && !string.IsNullOrEmpty(recoveryPeriodStartDateElement.Value))
                            {
                                DateTime recoveryPeriodStartDateInstance = DateTime.Parse(recoveryPeriodStartDateElement.Value, CultureInfo.InvariantCulture);
                                serviceResourceInstance.RecoveryPeriodStartDate = recoveryPeriodStartDateInstance;
                            }
                            
                            XElement nameElement = serviceResourceElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                            if (nameElement != null)
                            {
                                string nameInstance = nameElement.Value;
                                serviceResourceInstance.Name = nameInstance;
                            }
                            
                            XElement typeElement = serviceResourceElement.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                            if (typeElement != null)
                            {
                                string typeInstance = typeElement.Value;
                                serviceResourceInstance.Type = typeInstance;
                            }
                            
                            XElement stateElement = serviceResourceElement.Element(XName.Get("State", "http://schemas.microsoft.com/windowsazure"));
                            if (stateElement != null)
                            {
                                string stateInstance = stateElement.Value;
                                serviceResourceInstance.State = stateInstance;
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
        
        /// <summary>
        /// Returns a collection of databases that has been dropped but can
        /// still be restored from a specified server.
        /// </summary>
        /// <param name='serverName'>
        /// Required. The name of the Azure SQL Database Server to query for
        /// dropped databases that can still be restored.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Contains the response to the List Restorable Dropped Databases
        /// request.
        /// </returns>
        public async Task<RestorableDroppedDatabaseListResponse> ListAsync(string serverName, CancellationToken cancellationToken)
        {
            // Validate
            if (serverName == null)
            {
                throw new ArgumentNullException("serverName");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("serverName", serverName);
                TracingAdapter.Enter(invocationId, this, "ListAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "/" + (this.Client.Credentials.SubscriptionId == null ? "" : Uri.EscapeDataString(this.Client.Credentials.SubscriptionId)) + "/services/sqlservers/servers/" + Uri.EscapeDataString(serverName) + "/restorabledroppeddatabases?contentview=generic";
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("x-ms-version", "2012-03-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    RestorableDroppedDatabaseListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new RestorableDroppedDatabaseListResponse();
                        XDocument responseDoc = XDocument.Parse(responseContent);
                        
                        XElement serviceResourcesSequenceElement = responseDoc.Element(XName.Get("ServiceResources", "http://schemas.microsoft.com/windowsazure"));
                        if (serviceResourcesSequenceElement != null)
                        {
                            foreach (XElement serviceResourcesElement in serviceResourcesSequenceElement.Elements(XName.Get("ServiceResource", "http://schemas.microsoft.com/windowsazure")))
                            {
                                RestorableDroppedDatabase serviceResourceInstance = new RestorableDroppedDatabase();
                                result.Databases.Add(serviceResourceInstance);
                                
                                XElement entityIdElement = serviceResourcesElement.Element(XName.Get("EntityId", "http://schemas.microsoft.com/windowsazure"));
                                if (entityIdElement != null)
                                {
                                    string entityIdInstance = entityIdElement.Value;
                                    serviceResourceInstance.EntityId = entityIdInstance;
                                }
                                
                                XElement serverNameElement = serviceResourcesElement.Element(XName.Get("ServerName", "http://schemas.microsoft.com/windowsazure"));
                                if (serverNameElement != null)
                                {
                                    string serverNameInstance = serverNameElement.Value;
                                    serviceResourceInstance.ServerName = serverNameInstance;
                                }
                                
                                XElement editionElement = serviceResourcesElement.Element(XName.Get("Edition", "http://schemas.microsoft.com/windowsazure"));
                                if (editionElement != null)
                                {
                                    string editionInstance = editionElement.Value;
                                    serviceResourceInstance.Edition = editionInstance;
                                }
                                
                                XElement maxSizeBytesElement = serviceResourcesElement.Element(XName.Get("MaxSizeBytes", "http://schemas.microsoft.com/windowsazure"));
                                if (maxSizeBytesElement != null)
                                {
                                    long maxSizeBytesInstance = long.Parse(maxSizeBytesElement.Value, CultureInfo.InvariantCulture);
                                    serviceResourceInstance.MaximumDatabaseSizeInBytes = maxSizeBytesInstance;
                                }
                                
                                XElement creationDateElement = serviceResourcesElement.Element(XName.Get("CreationDate", "http://schemas.microsoft.com/windowsazure"));
                                if (creationDateElement != null)
                                {
                                    DateTime creationDateInstance = DateTime.Parse(creationDateElement.Value, CultureInfo.InvariantCulture);
                                    serviceResourceInstance.CreationDate = creationDateInstance;
                                }
                                
                                XElement deletionDateElement = serviceResourcesElement.Element(XName.Get("DeletionDate", "http://schemas.microsoft.com/windowsazure"));
                                if (deletionDateElement != null)
                                {
                                    DateTime deletionDateInstance = DateTime.Parse(deletionDateElement.Value, CultureInfo.InvariantCulture);
                                    serviceResourceInstance.DeletionDate = deletionDateInstance;
                                }
                                
                                XElement recoveryPeriodStartDateElement = serviceResourcesElement.Element(XName.Get("RecoveryPeriodStartDate", "http://schemas.microsoft.com/windowsazure"));
                                if (recoveryPeriodStartDateElement != null && !string.IsNullOrEmpty(recoveryPeriodStartDateElement.Value))
                                {
                                    DateTime recoveryPeriodStartDateInstance = DateTime.Parse(recoveryPeriodStartDateElement.Value, CultureInfo.InvariantCulture);
                                    serviceResourceInstance.RecoveryPeriodStartDate = recoveryPeriodStartDateInstance;
                                }
                                
                                XElement nameElement = serviceResourcesElement.Element(XName.Get("Name", "http://schemas.microsoft.com/windowsazure"));
                                if (nameElement != null)
                                {
                                    string nameInstance = nameElement.Value;
                                    serviceResourceInstance.Name = nameInstance;
                                }
                                
                                XElement typeElement = serviceResourcesElement.Element(XName.Get("Type", "http://schemas.microsoft.com/windowsazure"));
                                if (typeElement != null)
                                {
                                    string typeInstance = typeElement.Value;
                                    serviceResourceInstance.Type = typeInstance;
                                }
                                
                                XElement stateElement = serviceResourcesElement.Element(XName.Get("State", "http://schemas.microsoft.com/windowsazure"));
                                if (stateElement != null)
                                {
                                    string stateInstance = stateElement.Value;
                                    serviceResourceInstance.State = stateInstance;
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}
