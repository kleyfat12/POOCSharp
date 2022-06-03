using Accessor;

Employee employee = new Employee();
employee.Show();

employee.SetSalary(50000);
employee.SetName("Juan");
employee.Show();

employee.ShowLog();

Console.WriteLine(employee.GetSalary(1234));
Console.WriteLine(employee.GetTax(1234));

employee.ShowLog();