﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Anchovy.API.Client;
using Anchovy.API.Client.Models;
using Microsoft.Rest;

namespace Anchovy.API.Client
{
    public static partial class CrustsExtensions
    {
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ICrusts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Crust DeleteCrust(this ICrusts operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICrusts)s).DeleteCrustAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ICrusts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Crust> DeleteCrustAsync(this ICrusts operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<Anchovy.API.Client.Models.Crust> result = await operations.DeleteCrustWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ICrusts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Crust GetCrust(this ICrusts operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICrusts)s).GetCrustAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ICrusts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Crust> GetCrustAsync(this ICrusts operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<Anchovy.API.Client.Models.Crust> result = await operations.GetCrustWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ICrusts.
        /// </param>
        public static IList<Crust> GetCrusts(this ICrusts operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICrusts)s).GetCrustsAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ICrusts.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Crust>> GetCrustsAsync(this ICrusts operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<Anchovy.API.Client.Models.Crust>> result = await operations.GetCrustsWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ICrusts.
        /// </param>
        /// <param name='crust'>
        /// Required.
        /// </param>
        public static Crust PostCrust(this ICrusts operations, Crust crust)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICrusts)s).PostCrustAsync(crust);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ICrusts.
        /// </param>
        /// <param name='crust'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Crust> PostCrustAsync(this ICrusts operations, Crust crust, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<Anchovy.API.Client.Models.Crust> result = await operations.PostCrustWithOperationResponseAsync(crust, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ICrusts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='crust'>
        /// Required.
        /// </param>
        public static object PutCrust(this ICrusts operations, int id, Crust crust)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICrusts)s).PutCrustAsync(id, crust);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ICrusts.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='crust'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutCrustAsync(this ICrusts operations, int id, Crust crust, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutCrustWithOperationResponseAsync(id, crust, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
