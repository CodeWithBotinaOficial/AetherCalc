using System;
using System.Reactive;
using ReactiveUI;
using AetherCalc.Services;
using AetherCalc.Models;

namespace AetherCalc.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _displayText = "0";
    private double _firstNumber;
    private string? _currentOperation;
    private bool _isNewEntry = true;
    private readonly ICalculatorService _calculatorService;

    public string DisplayText
    {
        get => _displayText;
        set => this.RaiseAndSetIfChanged(ref _displayText, value);
    }

    public ReactiveCommand<string, Unit> AddNumberCommand { get; }
    public ReactiveCommand<string, Unit> SetOperationCommand { get; }
    public ReactiveCommand<Unit, Unit> CalculateCommand { get; }
    public ReactiveCommand<Unit, Unit> ClearCommand { get; }

    public MainWindowViewModel()
    {
        _calculatorService = new CalculatorService();

        AddNumberCommand = ReactiveCommand.Create<string>(AddNumber, outputScheduler: RxApp.MainThreadScheduler);
        SetOperationCommand = ReactiveCommand.Create<string>(SetOperation, outputScheduler: RxApp.MainThreadScheduler);
        CalculateCommand = ReactiveCommand.Create(ExecuteCalculate, outputScheduler: RxApp.MainThreadScheduler);
        ClearCommand = ReactiveCommand.Create(Reset, outputScheduler: RxApp.MainThreadScheduler);
    }

    private void AddNumber(string number)
    {
        if (_isNewEntry || DisplayText == "0")
        {
            DisplayText = number;
            _isNewEntry = false;
        }
        else
        {
            DisplayText += number;
        }
    }

    private void SetOperation(string operation)
    {
        _firstNumber = double.Parse(DisplayText);
        _currentOperation = operation;
        _isNewEntry = true;
    }

    private void ExecuteCalculate()
    {
        if (string.IsNullOrEmpty(_currentOperation)) return;

        var secondNumber = double.Parse(DisplayText);
        try
        {
            var result = _calculatorService.ExecuteOperation(_firstNumber, secondNumber, _currentOperation);
            DisplayText = result.ToString();
            _isNewEntry = true;
            _currentOperation = null;
        }
        catch (Exception)
        {
            DisplayText = "Error";
            _isNewEntry = true;
        }
    }

    private void Reset()
    {
        DisplayText = "0";
        _firstNumber = 0;
        _currentOperation = null;
        _isNewEntry = true;
    }
}