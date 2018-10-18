# HCL Workshop Hands-On
 
## Pre-requisites:

* Clone the repo: https://github.com/monojit18/HCL_Workshop 
* Create a resource group (e.g. hclworkshopgroup) in the Azure portal
* Create an App service plan in the process (e.g. hclserviceplan)
* Create a Storage in the process (e.g. hclstorage)
* Select a region for the resource group (e.g. EastUS)
* Create a Git repo for each project in the Cloned repo; this would help you to maintain your own CI/CD later on

### Exercise 1:

1.  Create a Xamarin.Forms or Xamarin.Native project
1.  You can make it a Tabbed page app or anything you want
2.  The Main page should have a Camera Capture option
3.  Implement the platform specific Capture Service using Dependency Service or some other DI/IoC framework (e.g. Autofaq)
4.  Add an Analyze Image button
5.  Now go to Azure portal
6.  Create a new resource – Computer Vision – under the resource group created above (e.g. hclworkshopgroup)
7.  Note the Url and Access Key 
8.  Refer to the TestAzureService project in the clones repo and try to implement the Analyze Image Button functionality
9.  Test it for both iOS and Android


### Exercise 2:

1.  Create a Xamarin.Forms or Xamarin.Native project
2.  The Main page should have a ListView
3.  Implement a function that downloads image from some dummy Urls
4.  Refer to TestPerformance App in the repo to get the dummy url
5.  Implement a function that Uploads dummy json object to some dummy Urls
6.  Refer to TestPerformance App in the repo to get the dummy url
7.  Keep no. of downloads/uploads to something between 1k-5k
8.  Make sure you can switch between the tabs or pages while the download and upload are in progress
9.  Now go to Azure portal
10. Create a new .NET based web API resource (e.g. QuickPostsApp)  – under the resource group created above (e.g. hclworkshopgroup)
11. Note the Url
12. Create a CosmosDB resource with Mongo API (e.g. hclcosmosmongodb)
13. Note down the URL and Access Key from the QuickStart menu option
14. Now create an empty Web API project in VS – named – QuickPostsApp – may be
15. Implement GET and PUT methods which in-turn would call appropriate mongo APIs
16. Publish the project from VS to Azure
17. If you have mongo installed locally – please test it once before publishing
18. Refer to EasyPostsApp in repo whenever you feel the need
19. Now come back to Xamarin project 
20. Add an Async Fetch and Async Upload to Web API
21. Update the ListView with data through Web API which comes from Mongo DB in Azure which is again wrapped in CosmosDB
22. Refer to the TestAzureServices project in the cloned repo whenever you need it
23. Make sure the API calls are implemented in the Shared Project in Xamarin
24. Test for both iOS and Android


### Exercise 3:

1.  Follow similar steps to create an Web Api that connects with Azure Blob and Table Storage
2.  Connect it from a Xamarin app
3.  Refer to EasyMobilApp in cloned repo


### Exercise 4:

1.  Go to https://aka.ms/appcenter  and create an account for your organization (e.g. hclappcenter)
2.  Create projects – one each for  Xamarin.iOS and Xamarin.Android
3.  Push your projects to some Git repo
4.  Connect the repo with AppCenter and define CI/CD
5.  Execute the Build and Release pipeline by checking in from the VS which triggers Build and Release as defined in the pipeline
6.  Create UITests in the Xamarin projects that you have just created – take examples from TestAppCenter project in the cloned repo
7.  Create a UI Test run in the appcenter portal and run the tests on multiple devices in the cloud


### Exercise 5:

1.  Go to https://app.vsaex.visualstudio.com   and create an account for your organization (e.g. hclDevOps)
2.  Create projects – one each for the two APIs you have just created
3.  Push your projects to some Git repo
4.  Connect the repo with VSTS and define CI/CD
5.  Execute the Build and Release pipeline by checking in from the VS which triggers Build and Release as defined in the pipeline

### Exercise 6:

1.  Go to Azure portal
2.  Create a Function instance
3.  Install windows Storage emulator on your desktop
4.  Connect to the hclstorage you had created earlier
5.  Create a Blob Container and Queue container
6.  Open TestAzureFunction project in cloned repo
7.  Execute ProcessBlob by triggering Blob update – using Storage emulator
8.  Try enabling the resiliency function and see how it affects the function flow through Live Metric in portal

### Exercise 7:

1.  Go to Azure portal
2.  Create an API Management instance
3.  Put your created APIs (2 &3) behind API management instance
4.  Protect your APIs using Azure AD
5.  Call APIs from client app (any of the Xamarin projects that you have just created)
