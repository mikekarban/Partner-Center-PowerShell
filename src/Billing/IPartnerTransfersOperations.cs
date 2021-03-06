// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing
{
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// PartnerTransfersOperations operations.
    /// </summary>
    public partial interface IPartnerTransfersOperations
    {
        /// <summary>
        /// Initiates the request to transfer the legacy subscriptions or RIs.
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='billingProfileName'>
        /// Billing Profile Id.
        /// </param>
        /// <param name='customerName'>
        /// Customer name.
        /// </param>
        /// <param name='parameters'>
        /// Parameters supplied to initiate the transfer.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<TransferDetails>> InitiateWithHttpMessagesAsync(string billingAccountName, string billingProfileName, string customerName, InitiateTransferRequest parameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the transfer details for given transfer Id.
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='billingProfileName'>
        /// Billing Profile Id.
        /// </param>
        /// <param name='customerName'>
        /// Customer name.
        /// </param>
        /// <param name='transferName'>
        /// Transfer Name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<TransferDetails>> GetWithHttpMessagesAsync(string billingAccountName, string billingProfileName, string customerName, string transferName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Cancels the transfer for given transfer Id.
        /// </summary>
        /// <param name='billingAccountName'>
        /// billing Account Id.
        /// </param>
        /// <param name='billingProfileName'>
        /// Billing Profile Id.
        /// </param>
        /// <param name='customerName'>
        /// Customer name.
        /// </param>
        /// <param name='transferName'>
        /// Transfer Name.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<TransferDetails>> CancelWithHttpMessagesAsync(string billingAccountName, string billingProfileName, string customerName, string transferName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
