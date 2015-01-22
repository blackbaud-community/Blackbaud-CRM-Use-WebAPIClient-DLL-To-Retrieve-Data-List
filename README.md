Blackbaud-CRM-Use-WebAPIClient-DLL-To-Retrieve-Data-List
========================================================

## What You Will Build ##

This customization demonstrates how to integrate a custom application with Blackbaud CRM to retrieve and iterate through a list of data in the Infinity database.

## Prerequisites ##

This customization requires familiarity with Infinity Web Service APIs and Data Lists, as well as concepts central to data lists such as context, security, and data list filters.

Within /AddAddressWinFormWebAPIClient.dll/AddAddressWinFormWebAPIClient.dll/Form1.vb  update Initialize() with the appropriate values for:
- AppFxWebService.asmx URL for your specific environment
- Provide a key which identifies the database
- Client Application name which will be logged in the Infinity database and used for auditing purposes


If you are new to the Infinity, you should refer to the [Introduction to Infinity Web Service APIs](https://www.blackbaud.com/files/support/guides/infinitydevguide/Subsystems/inwebapi-developer-help/inwebapi-developer-help.htm#InfinityWebAPI/coIntroductionToThe InfinityWebServiceAPIs.htm) article and the [Overview of Infinity Data Lists](https://www.blackbaud.com/files/support/guides/infinitydevguide/Subsystems/datalist-developer-help/Content/InfinityDataLists/cochDataList.htm) article.
##Resources##
* See the [Blackbaud CRM Read Me](https://github.com/blackbaud-community/Blackbaud-CRM/blob/master/README.md). 
* [Step by Step Instructions](https://www.blackbaud.com/files/support/guides/infinitydevguide/Subsystems/inwebapi-developer-help/Content/InfinityDataLists/coUsingAWebAPIClientDLLToRetrieveADataList.htm) for retrieving a data list
* [Infinity Web API](https://www.blackbaud.com/files/support/guides/infinitydevguide/infsdk-developer-help.htm#../Subsystems/inwebapi-developer-help/Content/InfinityWebAPI/WelcomeInfinityWebAPI.htm) Chapter within Developer Guides

##Contributing##

Third-party contributions are how we keep the code samples great. We want to keep it as easy as possible to contribute changes that show others how to do cool things with Blackbaud SDKs and APIs. There are a few guidelines that we need contributors to follow.

For more information, see our [canonical contributing guide](https://github.com/blackbaud-community/Blackbaud-CRM/blob/master/CONTRIBUTING.md) in the Blackbaud CRM repo which provides detailed instructions, including signing the [Contributor License Agreement](http://developer.blackbaud.com/cla).
