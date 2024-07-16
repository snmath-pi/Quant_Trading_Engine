# Trading Engine Server

## Overview

The Trading Engine Server is a robust, server-side application built from scratch using C# and Microsoft Visual Studio Code 2022. This application leverages Microsoft's hosting library and logging library to provide a reliable trading engine with dependency injection and singleton services.

## Features

- **Logging**: Uses Microsoft's logging library to log important actions and events.
- **Dependency Injection**: Utilizes a dependency injection container for better modularity and testability.
- **Singleton Service**: Ensures a single instance of the trading engine server.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or later)
- [Visual Studio Code](https://code.visualstudio.com/)

## Installation

1. **Clone the repository**:
    ```sh
    git clone https://github.com/snmath-pi/trading-engine-server.git
    cd trading-engine-server
    ```

2. **Build the project**:
    ```sh
    dotnet build
    ```

## Usage

1. **Run the application**:
    ```sh
    dotnet run
    ```

2. The server will start, and you should see logging information in the console output indicating the server's activities.

## Code Structure

- **RootNamespace**: `TradingEngineServer.Core`
- **Main Components**:
  - `Program.cs`: Entry point of the application where the host is built.
  - `Startup.cs`: Configures services and the app's request pipeline.
  - `LoggingService.cs`: Implements logging functionality.
  - `TradingEngine.cs`: Core trading engine logic.

## Contributing

Feel free to submit issues or pull requests. For major changes, please open an issue first to discuss what you would like to change.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
