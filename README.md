# AetherCalc

A modern, high-performance cross-platform calculator built with **Avalonia UI** and **.NET 10**. This project demonstrates a clean implementation of the **MVVM pattern** and service-oriented architecture.



## 🚀 Features
- **Modern UI**: Dark-themed, responsive interface designed with Avalonia Fluent Theme.
- **MVVM Architecture**: Decoupled logic and UI using ReactiveUI.
- **Service Layer**: Mathematical operations are encapsulated in a testable service.
- **High Performance**: Built on the latest .NET 10 runtime.

## 🛠 Prerequisites
To run this project, you need:
- [.NET SDK 10.0+](https://dotnet.microsoft.com/download)
- A system running Linux (tested on Ubuntu 22.04), Windows, or macOS.

## 📦 Getting Started

### 1. Clone the Repository
```bash
git clone https://github.com/CodeWithBotinaOficial/AetherCalc.git
cd AetherCalc

```

### 2. Restore Dependencies

```bash
dotnet restore

```

### 3. Build and Run

```bash
dotnet run --project src/AetherCalc/AetherCalc.csproj

```

## 🏗 Project Structure

* `src/AetherCalc/Models`: Business logic and mathematical engines.
* `src/AetherCalc/Services`: Interface definitions for core services.
* `src/AetherCalc/ViewModels`: Application state and command handling via ReactiveUI.
* `src/AetherCalc/Views`: XAML-based UI layouts.

## 📄 License

Licensed under the MIT License. See `LICENSE` for details.