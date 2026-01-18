# Contributing to AetherCalc

First of all, thank you for considering contributing to AetherCalc! 🚀

## 🛠 Development Environment
To work on this project, you will need:
- **.NET 10 SDK** or higher.
- **Avalonia UI Templates** (`dotnet new install Avalonia.Templates`).
- An IDE (We recommend **JetBrains Rider** or **VS Code** with Avalonia Extension).
- A Git client.

## 🏗 Project Architecture
AetherCalc follows the **MVVM (Model-View-ViewModel)** pattern:

- **Models**: Contains the `CalculatorService.cs` which handles the math logic.
- **ViewModels**: Handles data binding and UI commands using ReactiveUI.
- **Views**: Defined in XAML (`.axaml`) for the layout and styling.



## 🧪 Running Tests
Before submitting any change, ensure all unit tests pass:
```bash
dotnet test

```

## 🚀 How to Contribute

1. **Fork** the repository.
2. Create a **Feature Branch** (`git checkout -b feature/AmazingFeature`).
3. **Commit** your changes (`git commit -m 'Add some AmazingFeature'`).
4. **Push** to the branch (`git push origin feature/AmazingFeature`).
5. Open a **Pull Request**.

## 📝 Coding Standards

* Use **PascalCase** for classes and public methods.
* Use **_camelCase** for private fields.
* Ensure the code is formatted using `dotnet format`.