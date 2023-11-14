// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.DocumentIntelligence
{
    // Data plane generated client.
    /// <summary> The DocumentAnalysis service client. </summary>
    public partial class DocumentAnalysisClient
    {
        private const string AuthorizationHeader = "Ocp-Apim-Subscription-Key";
        private readonly AzureKeyCredential _keyCredential;
        private static readonly string[] AuthorizationScopes = new string[] { "https://cognitiveservices.azure.com/.default" };
        private readonly TokenCredential _tokenCredential;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> The HTTP pipeline for sending and receiving REST requests and responses. </summary>
        public virtual HttpPipeline Pipeline => _pipeline;

        /// <summary> Initializes a new instance of DocumentAnalysisClient for mocking. </summary>
        protected DocumentAnalysisClient()
        {
        }

        /// <summary> Initializes a new instance of DocumentAnalysisClient. </summary>
        /// <param name="endpoint"> The Document Intelligence service endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public DocumentAnalysisClient(Uri endpoint, AzureKeyCredential credential) : this(endpoint, credential, new AzureAIDocumentIntelligenceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of DocumentAnalysisClient. </summary>
        /// <param name="endpoint"> The Document Intelligence service endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public DocumentAnalysisClient(Uri endpoint, TokenCredential credential) : this(endpoint, credential, new AzureAIDocumentIntelligenceClientOptions())
        {
        }

        /// <summary> Initializes a new instance of DocumentAnalysisClient. </summary>
        /// <param name="endpoint"> The Document Intelligence service endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public DocumentAnalysisClient(Uri endpoint, AzureKeyCredential credential, AzureAIDocumentIntelligenceClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new AzureAIDocumentIntelligenceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _keyCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new AzureKeyCredentialPolicy(_keyCredential, AuthorizationHeader) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Initializes a new instance of DocumentAnalysisClient. </summary>
        /// <param name="endpoint"> The Document Intelligence service endpoint. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="endpoint"/> or <paramref name="credential"/> is null. </exception>
        public DocumentAnalysisClient(Uri endpoint, TokenCredential credential, AzureAIDocumentIntelligenceClientOptions options)
        {
            Argument.AssertNotNull(endpoint, nameof(endpoint));
            Argument.AssertNotNull(credential, nameof(credential));
            options ??= new AzureAIDocumentIntelligenceClientOptions();

            ClientDiagnostics = new ClientDiagnostics(options, true);
            _tokenCredential = credential;
            _pipeline = HttpPipelineBuilder.Build(options, Array.Empty<HttpPipelinePolicy>(), new HttpPipelinePolicy[] { new BearerTokenAuthenticationPolicy(_tokenCredential, AuthorizationScopes) }, new ResponseClassifier());
            _endpoint = endpoint;
            _apiVersion = options.Version;
        }

        /// <summary> Analyzes document with document model. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="analyzeRequest"> Analyze request parameters. </param>
        /// <param name="pages"> List of 1-based page numbers to analyze.  Ex. "1-3,5,7-9". </param>
        /// <param name="locale">
        /// Locale hint for text recognition and document analysis.  Value may contain only
        /// the language code (ex. "en", "fr") or BCP 47 language tag (ex. "en-US").
        /// </param>
        /// <param name="stringIndexType"> Method used to compute string offset and length. </param>
        /// <param name="features"> List of optional analysis features. </param>
        /// <param name="queryFields"> List of additional fields to extract.  Ex. "NumberOfGuests,StoreNumber". </param>
        /// <param name="outputContentFormat"> Format of the analyze result top-level content. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="modelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/DocumentAnalysisClient.xml" path="doc/members/member[@name='AnalyzeDocumentAsync(WaitUntil,string,AnalyzeDocumentRequest,string,string,StringIndexType?,IEnumerable{DocumentAnalysisFeature},IEnumerable{string},ContentFormat?,CancellationToken)']/*" />
        public virtual async Task<Operation<AnalyzeResult>> AnalyzeDocumentAsync(WaitUntil waitUntil, string modelId, AnalyzeDocumentRequest analyzeRequest = null, string pages = null, string locale = null, StringIndexType? stringIndexType = null, IEnumerable<DocumentAnalysisFeature> features = null, IEnumerable<string> queryFields = null, ContentFormat? outputContentFormat = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(modelId, nameof(modelId));

            RequestContext context = FromCancellationToken(cancellationToken);
            using RequestContent content = analyzeRequest?.ToRequestContent();
            Operation<BinaryData> response = await AnalyzeDocumentAsync(waitUntil, modelId, content, pages, locale, stringIndexType?.ToString(), features, queryFields, outputContentFormat?.ToString(), context).ConfigureAwait(false);
            return ProtocolOperationHelpers.Convert(response, AnalyzeResult.FromResponse, ClientDiagnostics, "DocumentAnalysisClient.AnalyzeDocument");
        }

        /// <summary> Analyzes document with document model. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="analyzeRequest"> Analyze request parameters. </param>
        /// <param name="pages"> List of 1-based page numbers to analyze.  Ex. "1-3,5,7-9". </param>
        /// <param name="locale">
        /// Locale hint for text recognition and document analysis.  Value may contain only
        /// the language code (ex. "en", "fr") or BCP 47 language tag (ex. "en-US").
        /// </param>
        /// <param name="stringIndexType"> Method used to compute string offset and length. </param>
        /// <param name="features"> List of optional analysis features. </param>
        /// <param name="queryFields"> List of additional fields to extract.  Ex. "NumberOfGuests,StoreNumber". </param>
        /// <param name="outputContentFormat"> Format of the analyze result top-level content. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="modelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/DocumentAnalysisClient.xml" path="doc/members/member[@name='AnalyzeDocument(WaitUntil,string,AnalyzeDocumentRequest,string,string,StringIndexType?,IEnumerable{DocumentAnalysisFeature},IEnumerable{string},ContentFormat?,CancellationToken)']/*" />
        public virtual Operation<AnalyzeResult> AnalyzeDocument(WaitUntil waitUntil, string modelId, AnalyzeDocumentRequest analyzeRequest = null, string pages = null, string locale = null, StringIndexType? stringIndexType = null, IEnumerable<DocumentAnalysisFeature> features = null, IEnumerable<string> queryFields = null, ContentFormat? outputContentFormat = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(modelId, nameof(modelId));

            RequestContext context = FromCancellationToken(cancellationToken);
            using RequestContent content = analyzeRequest?.ToRequestContent();
            Operation<BinaryData> response = AnalyzeDocument(waitUntil, modelId, content, pages, locale, stringIndexType?.ToString(), features, queryFields, outputContentFormat?.ToString(), context);
            return ProtocolOperationHelpers.Convert(response, AnalyzeResult.FromResponse, ClientDiagnostics, "DocumentAnalysisClient.AnalyzeDocument");
        }

        /// <summary>
        /// [Protocol Method] Analyzes document with document model.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="AnalyzeDocumentAsync(WaitUntil,string,AnalyzeDocumentRequest,string,string,StringIndexType?,IEnumerable{DocumentAnalysisFeature},IEnumerable{string},ContentFormat?,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="pages"> List of 1-based page numbers to analyze.  Ex. "1-3,5,7-9". </param>
        /// <param name="locale">
        /// Locale hint for text recognition and document analysis.  Value may contain only
        /// the language code (ex. "en", "fr") or BCP 47 language tag (ex. "en-US").
        /// </param>
        /// <param name="stringIndexType"> Method used to compute string offset and length. Allowed values: "textElements" | "unicodeCodePoint" | "utf16CodeUnit". </param>
        /// <param name="features"> List of optional analysis features. </param>
        /// <param name="queryFields"> List of additional fields to extract.  Ex. "NumberOfGuests,StoreNumber". </param>
        /// <param name="outputContentFormat"> Format of the analyze result top-level content. Allowed values: "text" | "markdown". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="modelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/DocumentAnalysisClient.xml" path="doc/members/member[@name='AnalyzeDocumentAsync(WaitUntil,string,RequestContent,string,string,string,IEnumerable{DocumentAnalysisFeature},IEnumerable{string},string,RequestContext)']/*" />
        public virtual async Task<Operation<BinaryData>> AnalyzeDocumentAsync(WaitUntil waitUntil, string modelId, RequestContent content, string pages = null, string locale = null, string stringIndexType = null, IEnumerable<DocumentAnalysisFeature> features = null, IEnumerable<string> queryFields = null, string outputContentFormat = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(modelId, nameof(modelId));

            using var scope = ClientDiagnostics.CreateScope("DocumentAnalysisClient.AnalyzeDocument");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnalyzeDocumentRequest(modelId, content, pages, locale, stringIndexType, features, queryFields, outputContentFormat, context);
                return await ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "DocumentAnalysisClient.AnalyzeDocument", OperationFinalStateVia.OperationLocation, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Analyzes document with document model.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="AnalyzeDocument(WaitUntil,string,AnalyzeDocumentRequest,string,string,StringIndexType?,IEnumerable{DocumentAnalysisFeature},IEnumerable{string},ContentFormat?,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="modelId"> Unique document model name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="pages"> List of 1-based page numbers to analyze.  Ex. "1-3,5,7-9". </param>
        /// <param name="locale">
        /// Locale hint for text recognition and document analysis.  Value may contain only
        /// the language code (ex. "en", "fr") or BCP 47 language tag (ex. "en-US").
        /// </param>
        /// <param name="stringIndexType"> Method used to compute string offset and length. Allowed values: "textElements" | "unicodeCodePoint" | "utf16CodeUnit". </param>
        /// <param name="features"> List of optional analysis features. </param>
        /// <param name="queryFields"> List of additional fields to extract.  Ex. "NumberOfGuests,StoreNumber". </param>
        /// <param name="outputContentFormat"> Format of the analyze result top-level content. Allowed values: "text" | "markdown". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="modelId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/DocumentAnalysisClient.xml" path="doc/members/member[@name='AnalyzeDocument(WaitUntil,string,RequestContent,string,string,string,IEnumerable{DocumentAnalysisFeature},IEnumerable{string},string,RequestContext)']/*" />
        public virtual Operation<BinaryData> AnalyzeDocument(WaitUntil waitUntil, string modelId, RequestContent content, string pages = null, string locale = null, string stringIndexType = null, IEnumerable<DocumentAnalysisFeature> features = null, IEnumerable<string> queryFields = null, string outputContentFormat = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(modelId, nameof(modelId));

            using var scope = ClientDiagnostics.CreateScope("DocumentAnalysisClient.AnalyzeDocument");
            scope.Start();
            try
            {
                using HttpMessage message = CreateAnalyzeDocumentRequest(modelId, content, pages, locale, stringIndexType, features, queryFields, outputContentFormat, context);
                return ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "DocumentAnalysisClient.AnalyzeDocument", OperationFinalStateVia.OperationLocation, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Classifies document with document classifier. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="classifierId"> Unique document classifier name. </param>
        /// <param name="classifyRequest"> Classify request parameters. </param>
        /// <param name="stringIndexType"> Method used to compute string offset and length. </param>
        /// <param name="split"> Document splitting mode. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="classifierId"/> or <paramref name="classifyRequest"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="classifierId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/DocumentAnalysisClient.xml" path="doc/members/member[@name='ClassifyDocumentAsync(WaitUntil,string,ClassifyDocumentRequest,StringIndexType?,SplitMode?,CancellationToken)']/*" />
        public virtual async Task<Operation<AnalyzeResult>> ClassifyDocumentAsync(WaitUntil waitUntil, string classifierId, ClassifyDocumentRequest classifyRequest, StringIndexType? stringIndexType = null, SplitMode? split = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(classifierId, nameof(classifierId));
            Argument.AssertNotNull(classifyRequest, nameof(classifyRequest));

            RequestContext context = FromCancellationToken(cancellationToken);
            using RequestContent content = classifyRequest.ToRequestContent();
            Operation<BinaryData> response = await ClassifyDocumentAsync(waitUntil, classifierId, content, stringIndexType?.ToString(), split?.ToString(), context).ConfigureAwait(false);
            return ProtocolOperationHelpers.Convert(response, AnalyzeResult.FromResponse, ClientDiagnostics, "DocumentAnalysisClient.ClassifyDocument");
        }

        /// <summary> Classifies document with document classifier. </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="classifierId"> Unique document classifier name. </param>
        /// <param name="classifyRequest"> Classify request parameters. </param>
        /// <param name="stringIndexType"> Method used to compute string offset and length. </param>
        /// <param name="split"> Document splitting mode. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="classifierId"/> or <paramref name="classifyRequest"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="classifierId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <include file="Docs/DocumentAnalysisClient.xml" path="doc/members/member[@name='ClassifyDocument(WaitUntil,string,ClassifyDocumentRequest,StringIndexType?,SplitMode?,CancellationToken)']/*" />
        public virtual Operation<AnalyzeResult> ClassifyDocument(WaitUntil waitUntil, string classifierId, ClassifyDocumentRequest classifyRequest, StringIndexType? stringIndexType = null, SplitMode? split = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(classifierId, nameof(classifierId));
            Argument.AssertNotNull(classifyRequest, nameof(classifyRequest));

            RequestContext context = FromCancellationToken(cancellationToken);
            using RequestContent content = classifyRequest.ToRequestContent();
            Operation<BinaryData> response = ClassifyDocument(waitUntil, classifierId, content, stringIndexType?.ToString(), split?.ToString(), context);
            return ProtocolOperationHelpers.Convert(response, AnalyzeResult.FromResponse, ClientDiagnostics, "DocumentAnalysisClient.ClassifyDocument");
        }

        /// <summary>
        /// [Protocol Method] Classifies document with document classifier.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="ClassifyDocumentAsync(WaitUntil,string,ClassifyDocumentRequest,StringIndexType?,SplitMode?,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="classifierId"> Unique document classifier name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="stringIndexType"> Method used to compute string offset and length. Allowed values: "textElements" | "unicodeCodePoint" | "utf16CodeUnit". </param>
        /// <param name="split"> Document splitting mode. Allowed values: "auto" | "none" | "perPage". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="classifierId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="classifierId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/DocumentAnalysisClient.xml" path="doc/members/member[@name='ClassifyDocumentAsync(WaitUntil,string,RequestContent,string,string,RequestContext)']/*" />
        public virtual async Task<Operation<BinaryData>> ClassifyDocumentAsync(WaitUntil waitUntil, string classifierId, RequestContent content, string stringIndexType = null, string split = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(classifierId, nameof(classifierId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("DocumentAnalysisClient.ClassifyDocument");
            scope.Start();
            try
            {
                using HttpMessage message = CreateClassifyDocumentRequest(classifierId, content, stringIndexType, split, context);
                return await ProtocolOperationHelpers.ProcessMessageAsync(_pipeline, message, ClientDiagnostics, "DocumentAnalysisClient.ClassifyDocument", OperationFinalStateVia.OperationLocation, context, waitUntil).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// [Protocol Method] Classifies document with document classifier.
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// This <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/ProtocolMethods.md">protocol method</see> allows explicit creation of the request and processing of the response for advanced scenarios.
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// Please try the simpler <see cref="ClassifyDocument(WaitUntil,string,ClassifyDocumentRequest,StringIndexType?,SplitMode?,CancellationToken)"/> convenience overload with strongly typed models first.
        /// </description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="classifierId"> Unique document classifier name. </param>
        /// <param name="content"> The content to send as the body of the request. </param>
        /// <param name="stringIndexType"> Method used to compute string offset and length. Allowed values: "textElements" | "unicodeCodePoint" | "utf16CodeUnit". </param>
        /// <param name="split"> Document splitting mode. Allowed values: "auto" | "none" | "perPage". </param>
        /// <param name="context"> The request context, which can override default behaviors of the client pipeline on a per-call basis. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="classifierId"/> or <paramref name="content"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="classifierId"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="RequestFailedException"> Service returned a non-success status code. </exception>
        /// <returns> The <see cref="Operation"/> representing an asynchronous operation on the service. </returns>
        /// <include file="Docs/DocumentAnalysisClient.xml" path="doc/members/member[@name='ClassifyDocument(WaitUntil,string,RequestContent,string,string,RequestContext)']/*" />
        public virtual Operation<BinaryData> ClassifyDocument(WaitUntil waitUntil, string classifierId, RequestContent content, string stringIndexType = null, string split = null, RequestContext context = null)
        {
            Argument.AssertNotNullOrEmpty(classifierId, nameof(classifierId));
            Argument.AssertNotNull(content, nameof(content));

            using var scope = ClientDiagnostics.CreateScope("DocumentAnalysisClient.ClassifyDocument");
            scope.Start();
            try
            {
                using HttpMessage message = CreateClassifyDocumentRequest(classifierId, content, stringIndexType, split, context);
                return ProtocolOperationHelpers.ProcessMessage(_pipeline, message, ClientDiagnostics, "DocumentAnalysisClient.ClassifyDocument", OperationFinalStateVia.OperationLocation, context, waitUntil);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateAnalyzeDocumentRequest(string modelId, RequestContent content, string pages, string locale, string stringIndexType, IEnumerable<DocumentAnalysisFeature> features, IEnumerable<string> queryFields, string outputContentFormat, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/documentintelligence", false);
            uri.AppendPath("/documentModels/", false);
            uri.AppendPath(modelId, true);
            uri.AppendPath(":analyze", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (pages != null)
            {
                uri.AppendQuery("pages", pages, true);
            }
            if (locale != null)
            {
                uri.AppendQuery("locale", locale, true);
            }
            if (stringIndexType != null)
            {
                uri.AppendQuery("stringIndexType", stringIndexType, true);
            }
            if (features != null && Optional.IsCollectionDefined(features))
            {
                uri.AppendQueryDelimited("features", features, ",", true);
            }
            if (queryFields != null && Optional.IsCollectionDefined(queryFields))
            {
                uri.AppendQueryDelimited("queryFields", queryFields, ",", true);
            }
            if (outputContentFormat != null)
            {
                uri.AppendQuery("outputContentFormat", outputContentFormat, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("content-type", "application/json");
            request.Content = content;
            return message;
        }

        internal HttpMessage CreateClassifyDocumentRequest(string classifierId, RequestContent content, string stringIndexType, string split, RequestContext context)
        {
            var message = _pipeline.CreateMessage(context, ResponseClassifier202);
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRaw("/documentintelligence", false);
            uri.AppendPath("/documentClassifiers/", false);
            uri.AppendPath(classifierId, true);
            uri.AppendPath(":analyze", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (stringIndexType != null)
            {
                uri.AppendQuery("stringIndexType", stringIndexType, true);
            }
            if (split != null)
            {
                uri.AppendQuery("split", split, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("content-type", "application/json");
            request.Content = content;
            return message;
        }

        private static RequestContext DefaultRequestContext = new RequestContext();
        internal static RequestContext FromCancellationToken(CancellationToken cancellationToken = default)
        {
            if (!cancellationToken.CanBeCanceled)
            {
                return DefaultRequestContext;
            }

            return new RequestContext() { CancellationToken = cancellationToken };
        }

        private static ResponseClassifier _responseClassifier202;
        private static ResponseClassifier ResponseClassifier202 => _responseClassifier202 ??= new StatusCodeClassifier(stackalloc ushort[] { 202 });
    }
}
