##ASP.NET Core Web API Boilerplate
This project serves as a boilerplate for building web APIs using ASP.NET Core. It is designed to kickstart the development process by providing a basic structure for the application, including an example of a controller with CRUD operations, a model boilerplate, and a service layer implementing a basic CRUD interface. Dependency injection is utilized to manage the service layer, enhancing the modularity and testability of the application.

##Features
Controller with CRUD Operations: An example controller is included that demonstrates Create, Read, Update, and Delete (CRUD) operations. Each operation returns a standardized response object, ensuring a consistent HTTP response structure across the API.
Model Boilerplate: A basic model is defined to represent the data structure. This model can be extended or modified to fit the specific needs of your application.
Service Layer: The core logic for CRUD operations is encapsulated within a service layer. This layer implements a boilerplate interface that defines basic CRUD operations, promoting a clean separation of concerns and making the codebase more maintainable.
Dependency Injection: Services are injected into controllers using ASP.NET Core's built-in dependency injection framework, defined in program.cs. This approach decouples the service implementation from its consumers, allowing for greater flexibility and easier testing.


##Getting Started
To get started with this boilerplate it is best to do so on Visual Studio Comunnity:
1.
download and install visual studio comunnity url: https://visualstudio.microsoft.com/vs/community/
2.
Clone the Repository
git clone https://github.com/vy1406/vgym-api.git
3.
Open the Project in Visual Studio Community:
Launch Visual Studio Community.
On the start window, select Open a project or solution.
Navigate to the folder where you cloned the repository, select the solution file (.sln), and click Open.


##Restoring Dependencies
Visual Studio Community should automatically restore all NuGet package dependencies when you open the project. However, if you need to manually restore the packages, follow these steps:

1.
Right-click on the Solution in Solution Explorer and select Restore NuGet Packages. This will download and install any missing packages required by the project.
2.
Build the Solution to ensure all dependencies are correctly restored and the project is ready to run. You can do this by selecting Build > Build Solution from the main menu.


##Running the Application
To run the ASP.NET Core Web API application within Visual Studio Community:

1.
Set the API Project as the Startup Project by right-clicking on the API project in Solution Explorer and selecting Set as Startup Project.
2.
Start the Application by clicking on the IIS Express button in the toolbar, or by pressing F5 to run with debugging, or Ctrl+F5 to run without debugging.
3.
the app will run on: https://localhost:7246, for more information look at solution-->properties-->launchSettings.json 

##Example Usage
The included example controller demonstrates how to perform CRUD operations. Here's a brief overview of how to interact with it:

Create: Send a POST request to /example with a JSON body representing the new item.
Read: Send a GET request to /example to retrieve all items, or /example/{id} to retrieve a specific item by ID.
Update: Send a PUT request to /example/{id} with a JSON body containing the updated data.
Delete: Send a DELETE request to /example/{id} to remove the specified item.


Extending the Boilerplate
To extend this boilerplate:

Add New Models: Define new models in the Models directory to represent additional data structures.
Extend the Service Layer: Implement additional services by extending the base interface or creating new interfaces and service implementations as needed.
Add Controllers: Create new controllers in the Controllers directory to handle different routes and operations.
