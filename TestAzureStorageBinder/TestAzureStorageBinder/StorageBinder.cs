using System;
using System.Linq;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using Subsystems.HttpConnection.External;

namespace TestAzureStorageBinder
{
    
    public class StorageBinder
    {

        private const string KLocalIPAddressString = "http://localhost:7000";
        private const string KStorageIPAddressString = "https://cognitiveapi.azure-api.net/storage/v1.0"; // "https://storagebinderapp.azurewebsites.net";
        private const string KAuthorizeString = "https://login.microsoftonline.com/72f988bf-86f1-41af-91ab-2d7cd011db47/oauth2/authorize";
        private const string KAccessTokenString = "https://login.microsoftonline.com/72f988bf-86f1-41af-91ab-2d7cd011db47/oauth2/token";
        private const string KResourceString = "https://microsoft.onmicrosoft.com/35368a64-ebff-47e4-b13e-f4f17bd803e0";
        private const string KClientIdString = "0d8fa901-36df-4ef6-9c1e-f0334619411b"; // "44faf8ab-e319-431c-84bc-b7def3e519c0";
        private const string kClientSecretString = "Y16A0WewGljUbyTpNZptvzhQij2vfZCoZfcjACgAais=";
        private const string KRedirectUriString = "https://cognitiveapi.portal.azure-api.net/docs/services/cognitiveapioauth/console/oauth2/authorizationcode/callback";

        private PlatformParameters _platformParameters;

        private async Task<string> AuthorizeAPIAsync()
        {

            var tk = new TokenCache();
            var authContext = new AuthenticationContext(KAuthorizeString);
            var clientCredential = new ClientCredential(KClientIdString, kClientSecretString);

            var authResult = await authContext.AcquireTokenAsync(KResourceString, KClientIdString,
                                                                 new Uri(KRedirectUriString), _platformParameters);

            // var authResult = await authContext.AcquireTokenAsync(KResourceString, clientCredential);            
            Console.WriteLine(authResult.AccessToken);
            return authResult.AccessToken;

        }

        public async Task<bool> TestDefaultAsync()
        {

            var bearerTokenString = await AuthorizeAPIAsync();

            var httpClientProxy = new CMPHttpConnectionProxy();
            httpClientProxy.URL($"{KStorageIPAddressString}/")
                           .Headers("Authorization", $"Bearer {bearerTokenString}")
                           .Headers("Ocp-Apim-Subscription-Key", "c0df4ea5d14d43d3afdf930ce5bba109")
                           .Build();

            var responseMessage = await httpClientProxy.GetAsync();
            return (string.IsNullOrEmpty(responseMessage.ResponseString) == false);

        }

        public async Task<bool> CreateTableAsync()
        {

            var bearerTokenString = await AuthorizeAPIAsync();

            var httpClientProxy = new CMPHttpConnectionProxy();
            httpClientProxy.URL($"{KStorageIPAddressString}/table/create")
                           .Headers("Authorization", $"Bearer {bearerTokenString}")
                           .Headers("Ocp-Apim-Subscription-Key", "ba179d3c8ded451d92ba54360c2d46e5")
                           .JsonBody("tablename", "testtable2018")
                           .Build();

            var responseMessage = await httpClientProxy.PutAsync();
            var responseModel = JsonConvert.DeserializeObject<BlobResponseModel>(responseMessage.ResponseString);
            if (responseModel == null)
                return false;

            return (string.IsNullOrEmpty(responseModel.Result?.ETag) == false);

        }

        public async Task<bool> DeleteTableAsync()
        {

            var bearerTokenString = await AuthorizeAPIAsync();

            var httpClientProxy = new CMPHttpConnectionProxy();
            httpClientProxy.URL($"{KStorageIPAddressString}/table/delete")
                           .Headers("Authorization", $"Bearer {bearerTokenString}")
                           .Headers("Ocp-Apim-Subscription-Key", "ba179d3c8ded451d92ba54360c2d46e5")
                           .JsonBody("tablename", "testtable2018")
                           .Build();

            var responseMessage = await httpClientProxy.DeleteAsync();
            var responseModel = JsonConvert.DeserializeObject<BlobResponseModel>(responseMessage.ResponseString);
            if (responseModel == null)
                return false;

            return (string.IsNullOrEmpty(responseModel.Result?.ETag) == false);

        }

        public async Task<bool> CreateQueueAsync()
        {

            var bearerTokenString = await AuthorizeAPIAsync();

            var httpClientProxy = new CMPHttpConnectionProxy();
            httpClientProxy.URL($"{KStorageIPAddressString}/queue/create")
                           .Headers("Authorization", $"Bearer {bearerTokenString}")
                           .Headers("Ocp-Apim-Subscription-Key", "ba179d3c8ded451d92ba54360c2d46e5")
                           .JsonBody("queuename", "testqueue2018")
                           .Build();

            var responseMessage = await httpClientProxy.PutAsync();
            var responseModel = JsonConvert.DeserializeObject<BlobResponseModel>(responseMessage.ResponseString);
            if (responseModel == null)
                return false;

            return (string.IsNullOrEmpty(responseModel.Result?.ETag) == false);

        }

        public async Task<bool> DeleteQueueAsync()
        {

            var bearerTokenString = await AuthorizeAPIAsync();

            var httpClientProxy = new CMPHttpConnectionProxy();
            httpClientProxy.URL($"{KStorageIPAddressString}/queue/delete")
                           .Headers("Authorization", $"Bearer {bearerTokenString}")
                           .Headers("Ocp-Apim-Subscription-Key", "ba179d3c8ded451d92ba54360c2d46e5")
                           .JsonBody("queuename", "testqueue2018")
                           .Build();

            var responseMessage = await httpClientProxy.DeleteAsync();
            var responseModel = JsonConvert.DeserializeObject<BlobResponseModel>(responseMessage.ResponseString);
            if (responseModel == null)
                return false;

            return (string.IsNullOrEmpty(responseModel.Result?.ETag) == false);

        }

        public async Task<bool> CreateBlobContainerAsync()
        {


            var bearerTokenString = await AuthorizeAPIAsync();

            var httpClientProxy = new CMPHttpConnectionProxy();
            httpClientProxy.URL($"{KStorageIPAddressString}/blob/container/create")
                           .Headers("Authorization", $"Bearer {bearerTokenString}")
                           .Headers("Ocp-Apim-Subscription-Key", "ba179d3c8ded451d92ba54360c2d46e5")
                           .JsonBody("containername", "testblob2018")
                           .Build();

            var responseMessage = await httpClientProxy.PutAsync();
            var responseModel = JsonConvert.DeserializeObject<BlobResponseModel>(responseMessage.ResponseString);
            if (responseModel == null)
                return false;

            return (string.IsNullOrEmpty(responseModel.Result?.ETag) == false);

        }

        public async Task<bool> DeleteBlobContainerAsync()
        {

            var bearerTokenString = await AuthorizeAPIAsync();

            var httpClientProxy = new CMPHttpConnectionProxy();
            httpClientProxy.URL($"{KStorageIPAddressString}/blob/container/delete")
                           .Headers("Authorization", $"Bearer {bearerTokenString}")
                           .Headers("Ocp-Apim-Subscription-Key", "ba179d3c8ded451d92ba54360c2d46e5")
                           .JsonBody("containername", "testblob2018")
                           .Build();

            var responseMessage = await httpClientProxy.DeleteAsync();
            var responseModel = JsonConvert.DeserializeObject<DeleteResponseModel>(responseMessage.ResponseString);
            if (responseModel == null)
                return false;

            return responseModel.Result;

        }

        public async Task<bool> UploadToBlobAsync()
        {

            var bearerTokenString = await AuthorizeAPIAsync();

            byte[] uploadBytes = null; // CapturedImageView.Image.AsJPEG().ToArray();
            var blobContentString = Convert.ToBase64String(uploadBytes);

            var httpClientProxy = new CMPHttpConnectionProxy();
            httpClientProxy.URL($"{KStorageIPAddressString}/blob/upload")
                           .Headers("Authorization", $"Bearer {bearerTokenString}")
                           .Headers("Ocp-Apim-Subscription-Key", "ba179d3c8ded451d92ba54360c2d46e5")
                           .JsonBody("containername", "testblob2018")
                           .JsonBody("blobname", "image_new.jpg")
                           .JsonBody("blob", blobContentString)
                           .Build();

            var responseMessage = await httpClientProxy.PutAsync();
            var responseModel = JsonConvert.DeserializeObject<BlobResponseModel>(responseMessage.ResponseString);
            if (responseModel == null)
                return false;

            return (string.IsNullOrEmpty(responseModel.Result?.ETag) == false);

        }

        public async Task<bool> DownloadFromBlobAsync()
        {

            var bearerTokenString = await AuthorizeAPIAsync();

            var httpClientProxy = new CMPHttpConnectionProxy();
            httpClientProxy.URL($"{KStorageIPAddressString}/blob/download")
                           .Headers("Authorization", $"Bearer {bearerTokenString}")
                           .Headers("Ocp-Apim-Subscription-Key", "ba179d3c8ded451d92ba54360c2d46e5")
                           .JsonBody("containername", "testblob2018")
                           .JsonBody("blobname", "image_new.jpg")
                           .Build();

            var responseMessage = await httpClientProxy.PostAsync();
            var responseModel = JsonConvert.DeserializeObject<BlobResponseModel>(responseMessage.ResponseString);
            if (responseModel == null)
                return false;

            return (string.IsNullOrEmpty(responseModel.Result?.ETag) == false);

        }

        public async Task<bool> DeleteBlobAsync()
        {

            var httpClientProxy = new CMPHttpConnectionProxy();
            httpClientProxy.URL($"{KStorageIPAddressString}/blob/container/create")
                           .Headers("Ocp-Apim-Subscription-Key", "ba179d3c8ded451d92ba54360c2d46e5")
                           .JsonBody("containername", "testblob2018")
                           .JsonBody("blobname", "image_new.jpg")
                           .Build();

            var responseMessage = await httpClientProxy.DeleteAsync();
            var responseModel = JsonConvert.DeserializeObject<BlobResponseModel>(responseMessage.ResponseString);
            if (responseModel == null)
                return false;

            return (string.IsNullOrEmpty(responseModel.Result?.ETag) == false);

        }

        public StorageBinder(PlatformParameters platformParameters)
        {

            _platformParameters = platformParameters;
        }


    }

    internal class BlobResponseModel
    {

        [JsonProperty("result")]
        public BlobResultModel Result { get; set; }

    }

    internal class BlobResultModel
    {

        [JsonProperty("etag")]
        public string ETag { get; set; }

    }

    internal class DeleteResponseModel
    {

        [JsonProperty("result")]
        public bool Result { get; set; }

    }
}
