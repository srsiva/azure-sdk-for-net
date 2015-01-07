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
using Microsoft.WindowsAzure.Management.ExpressRoute;
using Microsoft.WindowsAzure.Management.ExpressRoute.Models;

namespace Microsoft.WindowsAzure.Management.ExpressRoute
{
    /// <summary>
    /// The Express Route API provides programmatic access to the functionality
    /// needed by the customer to set up Dedicated Circuits and Dedicated
    /// Circuit Links. The Express Route Customer API is a REST API. All API
    /// operations are performed over SSL and mutually authenticated using
    /// X.509 v3 certificates.  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/ee460799.aspx for
    /// more information)
    /// </summary>
    public static partial class AuthorizedDedicatedCircuitOperationsExtensions
    {
        /// <summary>
        /// The Get Dedicated Circuit operation retrieves the specified
        /// authorized dedicated circuit.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ExpressRoute.IAuthorizedDedicatedCircuitOperations.
        /// </param>
        /// <param name='serviceKey'>
        /// Required. The service key representing the circuit.
        /// </param>
        /// <returns>
        /// The Get Authorized Dedicated Circuit operation response.
        /// </returns>
        public static AuthorizedDedicatedCircuitGetResponse Get(this IAuthorizedDedicatedCircuitOperations operations, string serviceKey)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAuthorizedDedicatedCircuitOperations)s).GetAsync(serviceKey);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The Get Dedicated Circuit operation retrieves the specified
        /// authorized dedicated circuit.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ExpressRoute.IAuthorizedDedicatedCircuitOperations.
        /// </param>
        /// <param name='serviceKey'>
        /// Required. The service key representing the circuit.
        /// </param>
        /// <returns>
        /// The Get Authorized Dedicated Circuit operation response.
        /// </returns>
        public static Task<AuthorizedDedicatedCircuitGetResponse> GetAsync(this IAuthorizedDedicatedCircuitOperations operations, string serviceKey)
        {
            return operations.GetAsync(serviceKey, CancellationToken.None);
        }
        
        /// <summary>
        /// The List Dedicated Circuit operation retrieves a list of dedicated
        /// circuits owned by the customer.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ExpressRoute.IAuthorizedDedicatedCircuitOperations.
        /// </param>
        /// <returns>
        /// The List Authorized Dedicated Circuit operation response.
        /// </returns>
        public static AuthorizedDedicatedCircuitListResponse List(this IAuthorizedDedicatedCircuitOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IAuthorizedDedicatedCircuitOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// The List Dedicated Circuit operation retrieves a list of dedicated
        /// circuits owned by the customer.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.WindowsAzure.Management.ExpressRoute.IAuthorizedDedicatedCircuitOperations.
        /// </param>
        /// <returns>
        /// The List Authorized Dedicated Circuit operation response.
        /// </returns>
        public static Task<AuthorizedDedicatedCircuitListResponse> ListAsync(this IAuthorizedDedicatedCircuitOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
    }
}
