// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Compute.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Compute
{
    /// <summary> A class representing collection of GalleryImage and their operations over a Gallery. </summary>
    public partial class GalleryImageContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly GalleryImagesRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="GalleryImageContainer"/> class for mocking. </summary>
        protected GalleryImageContainer()
        {
        }

        /// <summary> Initializes a new instance of GalleryImageContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal GalleryImageContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new GalleryImagesRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => Gallery.ResourceType;

        // Container level operations.

        /// <summary> Create or update a gallery image definition. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryImage"> Parameters supplied to the create or update gallery image operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> or <paramref name="galleryImage"/> is null. </exception>
        public virtual GalleryImageCreateOrUpdateOperation CreateOrUpdate(string galleryImageName, GalleryImageData galleryImage, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImage == null)
            {
                throw new ArgumentNullException(nameof(galleryImage));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage, cancellationToken);
                var operation = new GalleryImageCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Create or update a gallery image definition. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be created or updated. The allowed characters are alphabets and numbers with dots, dashes, and periods allowed in the middle. The maximum length is 80 characters. </param>
        /// <param name="galleryImage"> Parameters supplied to the create or update gallery image operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="galleryImageName"/> or <paramref name="galleryImage"/> is null. </exception>
        public async virtual Task<GalleryImageCreateOrUpdateOperation> CreateOrUpdateAsync(string galleryImageName, GalleryImageData galleryImage, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (galleryImageName == null)
            {
                throw new ArgumentNullException(nameof(galleryImageName));
            }
            if (galleryImage == null)
            {
                throw new ArgumentNullException(nameof(galleryImage));
            }

            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage, cancellationToken).ConfigureAwait(false);
                var operation = new GalleryImageCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, galleryImageName, galleryImage).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<GalleryImage> Get(string galleryImageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.Get");
            scope.Start();
            try
            {
                if (galleryImageName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new GalleryImage(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<GalleryImage>> GetAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.Get");
            scope.Start();
            try
            {
                if (galleryImageName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new GalleryImage(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<GalleryImage> GetIfExists(string galleryImageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.GetIfExists");
            scope.Start();
            try
            {
                if (galleryImageName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<GalleryImage>(null, response.GetRawResponse())
                    : Response.FromValue(new GalleryImage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<GalleryImage>> GetIfExistsAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.GetIfExists");
            scope.Start();
            try
            {
                if (galleryImageName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<GalleryImage>(null, response.GetRawResponse())
                    : Response.FromValue(new GalleryImage(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string galleryImageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (galleryImageName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageName));
                }

                var response = GetIfExists(galleryImageName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="galleryImageName"> The name of the gallery image definition to be retrieved. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string galleryImageName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (galleryImageName == null)
                {
                    throw new ArgumentNullException(nameof(galleryImageName));
                }

                var response = await GetIfExistsAsync(galleryImageName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> List gallery image definitions in a gallery. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="GalleryImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GalleryImage> GetAll(CancellationToken cancellationToken = default)
        {
            Page<GalleryImage> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByGallery(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<GalleryImage> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllByGalleryNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> List gallery image definitions in a gallery. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="GalleryImage" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GalleryImage> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<GalleryImage>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByGalleryAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<GalleryImage>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllByGalleryNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new GalleryImage(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="GalleryImage" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(GalleryImage.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="GalleryImage" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("GalleryImageContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(GalleryImage.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, GalleryImage, GalleryImageData> Construct() { }
    }
}
