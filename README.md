# serverlessapisample
Contains artefacts used in the Blog article that explains how Azure Functions, CosmosDB and Powerapps could be used to build Applications

Azure Functions can be used to quickly stand up Application Services, using a Micro Services based architecture, complete with integration with other Azure Services like Cosmos DB, Queues, Blobs, etc , through the use of Input and output Bindings. Inbuilt tools can be used to generate Swagger definitions for these Services and consume them in Client side Applications running across device platforms.
In this article , an Azure Function App comprising of 2 different Functions that perform CRUD operations on data residing in Azure Cosmos DB, will be created. The Function App would be exposed as a REST callable endpoint that would be consumed by a Microsoft Powerapps Application. This use case does not require an IDE for development. It can be built entirely from the Azure Portal and the browser.
