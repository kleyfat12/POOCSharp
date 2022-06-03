using PrivatePublicAccess;

Calculator calculator = new Calculator();

// I can accesss "a" and "b", because they are public
calculator.a = 1;
calculator.b = 1;

// But I can not access "r"
// Console.WriteLine(calculator.r);
// calculator.r = 4;

// I can access Suma
calculator.Suma();

//But can not access "Muestra" method
//calculator.Muestra();