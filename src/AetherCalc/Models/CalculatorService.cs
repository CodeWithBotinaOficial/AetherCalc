using System;
using AetherCalc.Services;

namespace AetherCalc.Models;

/// <summary>
/// Business logic for mathematical operations.
/// </summary>
public class CalculatorService : ICalculatorService
{
    public double ExecuteOperation(double left, double right, string operation)
    {
        return operation switch
        {
            "+" => left + right,
            "-" => left - right,
            "*" => left * right,
            "/" => right != 0 ? left / right : throw new DivideByZeroException("Cannot divide by zero"),
            _ => throw new InvalidOperationException("Unknown operator")
        };
    }
}