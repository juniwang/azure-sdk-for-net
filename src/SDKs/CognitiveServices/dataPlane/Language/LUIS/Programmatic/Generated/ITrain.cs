// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Programmatic
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Train operations.
    /// </summary>
    public partial interface ITrain
    {
        /// <summary>
        /// Sends a training request for a version of a specified LUIS app.
        /// This POST request initiates a request asynchronously. To determine
        /// whether the training request is successful, submit a GET request to
        /// get training status. Note: The application version is not fully
        /// trained unless all the models (intents and entities) are trained
        /// successfully or are up to date. To verify training success, get the
        /// training status at least once after training is complete.
        /// </summary>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
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
        Task<HttpOperationResponse<EnqueueTrainingResponse>> TrainVersionWithHttpMessagesAsync(System.Guid appId, string versionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the training status of all models (intents and entities) for
        /// the specified LUIS app. You must call the train API to train the
        /// LUIS app before you call this API to get training status. "appID"
        /// specifies the LUIS app ID. "versionId" specifies the version number
        /// of the LUIS app. For example, "0.1".
        /// </summary>
        /// <param name='appId'>
        /// The application ID.
        /// </param>
        /// <param name='versionId'>
        /// The version ID.
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
        Task<HttpOperationResponse<IList<ModelTrainingInfo>>> GetStatusWithHttpMessagesAsync(System.Guid appId, string versionId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
