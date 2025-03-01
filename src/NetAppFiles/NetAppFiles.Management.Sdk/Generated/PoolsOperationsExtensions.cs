// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
namespace Microsoft.Azure.Management.NetApp
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for PoolsOperations
    /// </summary>
    public static partial class PoolsOperationsExtensions
    {
        /// <summary>
        /// List all capacity pools in the NetApp Account
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        public static Microsoft.Rest.Azure.IPage<CapacityPool> List(this IPoolsOperations operations, string resourceGroupName, string accountName)
        {
                return ((IPoolsOperations)operations).ListAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List all capacity pools in the NetApp Account
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<CapacityPool>> ListAsync(this IPoolsOperations operations, string resourceGroupName, string accountName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Get details of the specified capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        public static CapacityPool Get(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName)
        {
                return ((IPoolsOperations)operations).GetAsync(resourceGroupName, accountName, poolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get details of the specified capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<CapacityPool> GetAsync(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, poolName, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Create or Update a capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        public static CapacityPool CreateOrUpdate(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName, CapacityPool body)
        {
                return ((IPoolsOperations)operations).CreateOrUpdateAsync(resourceGroupName, accountName, poolName, body).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create or Update a capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<CapacityPool> CreateOrUpdateAsync(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName, CapacityPool body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, poolName, body, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Patch the specified capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        public static CapacityPool Update(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName, CapacityPoolPatch body)
        {
                return ((IPoolsOperations)operations).UpdateAsync(resourceGroupName, accountName, poolName, body).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Patch the specified capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<CapacityPool> UpdateAsync(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName, CapacityPoolPatch body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, accountName, poolName, body, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Delete the specified capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        public static void Delete(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName)
        {
                ((IPoolsOperations)operations).DeleteAsync(resourceGroupName, accountName, poolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete the specified capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task DeleteAsync(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, poolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// Create or Update a capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        public static CapacityPool BeginCreateOrUpdate(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName, CapacityPool body)
        {
                return ((IPoolsOperations)operations).BeginCreateOrUpdateAsync(resourceGroupName, accountName, poolName, body).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Create or Update a capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<CapacityPool> BeginCreateOrUpdateAsync(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName, CapacityPool body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, accountName, poolName, body, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Patch the specified capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        public static CapacityPool BeginUpdate(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName, CapacityPoolPatch body)
        {
                return ((IPoolsOperations)operations).BeginUpdateAsync(resourceGroupName, accountName, poolName, body).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Patch the specified capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<CapacityPool> BeginUpdateAsync(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName, CapacityPoolPatch body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, accountName, poolName, body, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
        /// <summary>
        /// Delete the specified capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        public static void BeginDelete(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName)
        {
                ((IPoolsOperations)operations).BeginDeleteAsync(resourceGroupName, accountName, poolName).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Delete the specified capacity pool
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// The name of the NetApp account
        /// </param>
        /// <param name='poolName'>
        /// The name of the capacity pool
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task BeginDeleteAsync(this IPoolsOperations operations, string resourceGroupName, string accountName, string poolName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, poolName, null, cancellationToken).ConfigureAwait(false)).Dispose();
        }
        /// <summary>
        /// List all capacity pools in the NetApp Account
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        public static Microsoft.Rest.Azure.IPage<CapacityPool> ListNext(this IPoolsOperations operations, string nextPageLink)
        {
                return ((IPoolsOperations)operations).ListNextAsync(nextPageLink).GetAwaiter().GetResult();
        }

        /// <summary>
        /// List all capacity pools in the NetApp Account
        /// </summary>
        /// <param name='operations'>
        /// The operations group for this extension method.
        /// </param>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        public static async System.Threading.Tasks.Task<Microsoft.Rest.Azure.IPage<CapacityPool>> ListNextAsync(this IPoolsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
            {
                return _result.Body;
            }
        }
    }
}
