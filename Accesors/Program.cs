using Accessor;

Employee employee = new Employee();
employee.Show();

employee.SetSalary(40000);
employee.SetName("Juan");

employee.Show();

employee.CaculateTax();

employee.Show();