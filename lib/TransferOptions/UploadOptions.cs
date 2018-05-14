//------------------------------------------------------------------------------
// <copyright file="UploadOptions.cs" company="Microsoft">
//    Copyright (c) Microsoft Corporation
// </copyright>
//------------------------------------------------------------------------------
using Microsoft.WindowsAzure.Storage.RetryPolicies;
namespace Microsoft.WindowsAzure.Storage.DataMovement
{
    /// <summary>
    /// Represents a set of options that may be specified for upload operation
    /// </summary>
    public sealed class UploadOptions
    {
        /// <summary>
        /// Gets or sets an <see cref="AccessCondition"/> object that represents the access conditions for the destination object. If <c>null</c>, no condition is used.
        /// </summary>
        public AccessCondition DestinationAccessCondition { get; set; }

        /// <summary>
        /// Gets or sets an <see cref="IRetryPolicy"/> object that represents the retry policy for the request. If <c>null</c>, no retry policy is used.
        /// </summary>
        public IRetryPolicy RetryPolicy { get; set; }
    }
}
