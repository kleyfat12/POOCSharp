using Scope;

Calculator calculator = new Calculator();

// If i try to use this in calculator, it fails
// We only can use it in Program.cs
int c = 100;

calculator.a = 20;
calculator.b = 40;

calculator.Suma();
calculator.Muestra();
