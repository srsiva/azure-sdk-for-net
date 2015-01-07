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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.StreamAnalytics;
using Microsoft.Azure.Management.StreamAnalytics.Models;

namespace Microsoft.Azure.Management.StreamAnalytics
{
    public partial interface IStreamAnalyticsManagementClient : IDisposable
    {
        /// <summary>
        /// The URI used as the base for all Service Management requests.
        /// </summary>
        Uri BaseUri
        {
            get; set; 
        }
        
        /// <summary>
        /// When you create a Windows Azure subscription, it is uniquely
        /// identified by a subscription ID. The subscription ID forms part of
        /// the URI for every call that you make to the Service Management
        /// API. The Windows Azure Service ManagementAPI use mutual
        /// authentication of management certificates over SSL to ensure that
        /// a request made to the service is secure. No anonymous requests are
        /// allowed.
        /// </summary>
        SubscriptionCloudCredentials Credentials
        {
            get; set; 
        }
        
        /// <summary>
        /// Operations for managing the input of the stream analytics job.
        /// </summary>
        IInputOperations Inputs
        {
            get; 
        }
        
        /// <summary>
        /// Operations for managing the stream analytics job.
        /// </summary>
        IJobOperations StreamingJobs
        {
            get; 
        }
        
        /// <summary>
        /// Operations for managing the output of the stream analytics job.
        /// </summary>
        IOutputOperations Outputs
        {
            get; 
        }
        
        /// <summary>
        /// Operations for Azure Stream Analytics subscription information.
        /// </summary>
        ISubscriptionOperations Subscriptions
        {
            get; 
        }
        
        /// <summary>
        /// Operations for managing the transformation definition of the stream
        /// analytics job.
        /// </summary>
        ITransformationOperations Transformations
        {
            get; 
        }
        
        /// <summary>
        /// The Get Operation Status operation returns the status of the
        /// specified operation. After calling an asynchronous operation, you
        /// can call Get Operation Status to determine whether the operation
        /// has succeeded, failed, or is still in progress.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response for long running operations.
        /// </returns>
        Task<LongRunningOperationResponse> GetLongRunningOperationStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The test result of the input or output data source.
        /// </returns>
        Task<DataSourceTestConnectionResponse> GetTestConnectionStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
    }
}
