namespace AetherCalc.Services;

public interface ICalculatorService
{
    double ExecuteOperation(double left, double right, string operation);
}