﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Rest;
using Offleaseonly;

namespace Offleaseonly
{
    public static partial class ScrapeExtensions
    {
        /// <param name='operations'>
        /// Reference to the Offleaseonly.IScrape.
        /// </param>
        /// <param name='count'>
        /// Optional.
        /// </param>
        public static string Get(this IScrape operations, int? count = null)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IScrape)s).GetAsync(count);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Offleaseonly.IScrape.
        /// </param>
        /// <param name='count'>
        /// Optional.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<string> GetAsync(this IScrape operations, int? count = null, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<string> result = await operations.GetWithOperationResponseAsync(count, cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
        
        /// <param name='operations'>
        /// Reference to the Offleaseonly.IScrape.
        /// </param>
        public static bool Post(this IScrape operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((IScrape)s).PostAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <param name='operations'>
        /// Reference to the Offleaseonly.IScrape.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public static async Task<bool> PostAsync(this IScrape operations, CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Microsoft.Rest.HttpOperationResponse<bool> result = await operations.PostWithOperationResponseAsync(cancellationToken).ConfigureAwait(false);
            return result.Body;
        }
    }
}
