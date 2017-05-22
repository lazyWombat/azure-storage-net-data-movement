//------------------------------------------------------------------------------
// <copyright file="TransferLocationType.cs" company="Microsoft">
//    Copyright (c) Microsoft Corporation
// </copyright>
//------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Storage.DataMovement
{
    public enum TransferLocationType
    {
        FilePath,
        Stream,
        AzureBlob,
        AzureFile,
        SourceUri,
        LocalDirectory,
        AzureBlobDirectory,
        AzureFileDirectory,
    }
}
