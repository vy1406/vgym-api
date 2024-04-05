# ASP.NET Core Web API Boilerplate for Vgym Server-side

This project serves as a robust boilerplate for building web APIs using ASP.NET Core, specifically tailored for the Vgym server-side application. Designed to streamline the development process, this boilerplate provides a foundational structure, including a sample controller with CRUD operations, a model template, and a service layer that implements a basic CRUD interface. Leveraging ASP.NET Core's built-in dependency injection framework, the service layer's management enhances the application's modularity and testability.

## Features

- **Controller with CRUD Operations**: Includes an example controller that demonstrates comprehensive Create, Read, Update, and Delete (CRUD) operations. Each operation is designed to return a standardized response object, ensuring a consistent HTTP response structure across the API.

- **Model Boilerplate**: Features a basic model template to represent the application's data structure. This model can be easily extended or modified to meet the specific needs of your application.

- **Service Layer**: Encapsulates the core logic for CRUD operations within a service layer. This layer adheres to a boilerplate interface that outlines basic CRUD operations, fostering a clean separation of concerns and enhancing the maintainability of the codebase.

- **Dependency Injection**: Utilizes ASP.NET Core's dependency injection framework, as defined in `program.cs`, to inject services into controllers. This strategy effectively decouples the service implementation from its consumers, offering increased flexibility and facilitating easier testing.

## Getting Started

Follow these steps to get started with the Vgym ASP.NET Core Web API boilerplate using Visual Studio Community:

### Prerequisites

- Download and install [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/).

### Setup

1. **Clone the Repository**: Clone the Vgym API repository to your local machine using the following command:
   ```bash
   git clone https://github.com/vy1406/vgym-api.git
   ```

2. **Open the Project in Visual Studio Community**:
   - Launch Visual Studio Community.
   - From the start window, select **Open a project or solution**.
   - Navigate to the folder where you cloned the repository, select the solution file (`.sln`), and click **Open**.

## Restoring Dependencies

Visual Studio Community should automatically restore all NuGet package dependencies upon opening the project. If manual restoration is needed, follow these steps:

1. Right-click on the Solution in Solution Explorer and select **Restore NuGet Packages** to download and install any missing packages.
2. **Build the Solution** to ensure all dependencies are correctly restored and the project is ready to run. Navigate to **Build > Build Solution** from the main menu.

## Running the Application

To run the Vgym ASP.NET Core Web API application within Visual Studio Community:

1. Set the API Project as the Startup Project by right-clicking on the API project in Solution Explorer and selecting **Set as Startup Project**.
2. Start the Application by clicking on the **IIS Express** button in the toolbar, or by pressing `F5` to run with debugging, or `Ctrl+F5` to run without debugging.
3. The application will run on `https://localhost:7246`. For more detailed configuration, refer to `solution > properties > launchSettings.json`.

## Example Usage

The boilerplate includes an example controller to demonstrate CRUD operations. Here's a quick guide:

- **Create**: Send a `POST` request to `/example` with a JSON body representing the new item.
- **Read**: Send a `GET` request to `/example` to retrieve all items, or `/example/{id}` for a specific item by ID.
- **Update**: Send a `PUT` request to `/example/{id}` with a JSON body containing the updated data.
- **Delete**: Send a `DELETE` request to `/example/{id}` to remove the specified item.
