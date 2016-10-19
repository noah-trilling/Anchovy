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
    public static partial class OrdersExtensions
    {
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.IOrders.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Order DeleteOrder(this IOrders operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IOrders)s).DeleteOrderAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.IOrders.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Order> DeleteOrderAsync(this IOrders operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<Anchovy.API.Client.Models.Order> result = await operations.DeleteOrderWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.IOrders.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        public static Order GetOrder(this IOrders operations, int id)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IOrders)s).GetOrderAsync(id);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.IOrders.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Order> GetOrderAsync(this IOrders operations, int id, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<Anchovy.API.Client.Models.Order> result = await operations.GetOrderWithOperationResponseAsync(id, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.IOrders.
        /// </param>
        public static IList<Order> GetOrders(this IOrders operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IOrders)s).GetOrdersAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.IOrders.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<IList<Order>> GetOrdersAsync(this IOrders operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<System.Collections.Generic.IList<Anchovy.API.Client.Models.Order>> result = await operations.GetOrdersWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.IOrders.
        /// </param>
        /// <param name='order'>
        /// Required.
        /// </param>
        public static Order PostOrder(this IOrders operations, Order order)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IOrders)s).PostOrderAsync(order);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.IOrders.
        /// </param>
        /// <param name='order'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<Order> PostOrderAsync(this IOrders operations, Order order, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<Anchovy.API.Client.Models.Order> result = await operations.PostOrderWithOperationResponseAsync(order, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.IOrders.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='order'>
        /// Required.
        /// </param>
        public static object PutOrder(this IOrders operations, int id, Order order)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IOrders)s).PutOrderAsync(id, order);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Anchovy.API.Client.IOrders.
        /// </param>
        /// <param name='id'>
        /// Required.
        /// </param>
        /// <param name='order'>
        /// Required.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<object> PutOrderAsync(this IOrders operations, int id, Order order, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<object> result = await operations.PutOrderWithOperationResponseAsync(id, order, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
