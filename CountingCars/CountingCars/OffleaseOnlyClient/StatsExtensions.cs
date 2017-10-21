﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace OffleaseOnly
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for Stats.
    /// </summary>
    public static partial class StatsExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static CarStats CarStats(this IStats operations)
            {
                return Task.Factory.StartNew(s => ((IStats)s).CarStatsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CarStats> CarStatsAsync(this IStats operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CarStatsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IDictionary<string, int?> PriceStats(this IStats operations)
            {
                return Task.Factory.StartNew(s => ((IStats)s).PriceStatsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, int?>> PriceStatsAsync(this IStats operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PriceStatsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IDictionary<string, int?> AddedStats(this IStats operations)
            {
                return Task.Factory.StartNew(s => ((IStats)s).AddedStatsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IDictionary<string, int?>> AddedStatsAsync(this IStats operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddedStatsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}