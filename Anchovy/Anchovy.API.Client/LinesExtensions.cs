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
    public static partial class LinesExtensions
    {
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ILines.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Line DeleteLine(this ILines operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILines)s).DeleteLineAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ILines.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Line> DeleteLineAsync(this ILines operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<Anchovy.API.Client.Models.Line> result = await operations.DeleteLineWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ILines.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Line GetLine(this ILines operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILines)s).GetLineAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ILines.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Line> GetLineAsync(this ILines operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<Anchovy.API.Client.Models.Line> result = await operations.GetLineWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ILines.
        /// </param>
        public static IList<Line> GetLines(this ILines operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILines)s).GetLinesAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ILines.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Line>> GetLinesAsync(this ILines operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<Anchovy.API.Client.Models.Line>> result = await operations.GetLinesWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ILines.
        /// </param>
        /// <param name='line'>
        /// Required.
        /// </param>
        public static Line PostLine(this ILines operations, Line line)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILines)s).PostLineAsync(line);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ILines.
        /// </param>
        /// <param name='line'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Line> PostLineAsync(this ILines operations, Line line, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<Anchovy.API.Client.Models.Line> result = await operations.PostLineWithOperationResponseAsync(line, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ILines.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='line'>
        /// Required.
        /// </param>
        public static object PutLine(this ILines operations, int id, Line line)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ILines)s).PutLineAsync(id, line);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.ILines.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='line'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutLineAsync(this ILines operations, int id, Line line, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutLineWithOperationResponseAsync(id, line, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
