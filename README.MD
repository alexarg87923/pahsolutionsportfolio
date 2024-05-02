# PAHSolutions Portfolio

## Introduction

This project is a .NET MVC application designed to showcase [describe the purpose or features of your project]. It leverages the ASP.NET Core framework to provide a robust and scalable web application.

## Getting Started

These instructions will get your copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

Before you can run this project, you'll need to set up your development environment. The project is built with the .NET Core framework, which requires the .NET SDK and runtime, as well as a database. This guide includes instructions for setting up MySQL, which is required for the project's data storage.

### Installing Dependencies

1. **Visual Studio Code (VSC)**: If you don't have Visual Studio Code, download and install it from [here](https://code.visualstudio.com/).

2. **.NET SDK and Runtime**: 
   - For a guided installation, visit [this page](https://code.visualstudio.com/docs/languages/dotnet) to understand how to install the necessary .NET dependencies.
   - Alternatively, you can directly install the required extensions and coding packs for Visual Studio Code:
     - [C# Extension for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit) - Essential for .NET development in VSC.
     - For **Windows** users, download the .NET Coding Pack [here](https://aka.ms/dotnet-coding-pack-win).
     - For **Mac** users, download the .NET Coding Pack [here](https://aka.ms/dotnet-coding-pack-mac).
   - You can also directly download the .NET SDK from [this link](https://aka.ms/vscDocs/dotnet/download).

3. **Database Setup**:
   - **Windows Users**: Follow this tutorial to install MySQL on your WSL (Windows Subsystem for Linux): [Install MySQL on WSL](https://docs.microsoft.com/en-us/windows/wsl/tutorials/wsl-database#installing-mysql). This step is crucial for setting up the database environment required for the project.
   - **Mac Users**: You can install MySQL using Homebrew. Open your terminal and run:
     ```
     brew install mysql
     ```
     After installation, start the MySQL service:
     ```
     brew services start mysql
     ```
     Secure your MySQL installation:
     ```
     mysql_secure_installation
     ```
   - After setting up MySQL, create a new database for the project and note the credentials, as you will need to configure these in the project settings.

### Setting Up the Project

1. Clone the repository to your local machine:
   ```
   git clone [repository-url]
   ```
2. Open the cloned directory in Visual Studio Code.

3. Restore the .NET Core packages:
   ```
   dotnet restore
   ```

4. Build the project to ensure everything is set up correctly:
   ```
   dotnet build
   ```

5. Configure your database connection strings in the project settings to connect to the database you set up during the Database Setup step.

### Running the Project

To run the project locally, use the following command in the terminal:
   ```
   dotnet watch run
   ```
This command will start the application. You can access it by navigating to `http://localhost:[port]/` in your web browser, where `[port]` is the port number outputted to your terminal.

## Contributing

Please read [CONTRIBUTING.md](/CONTRIBUTING.md) for details on our code of conduct, and the process for submitting pull requests to us.

## License

This project is licensed under the [LICENSE.md](/LICENSE.md) - see the file for details.

## Acknowledgments

- Mention any inspiration, article references, or libraries used in the project.
