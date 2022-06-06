using Inheritance;

Person person = new Person("Fernando", "Carrillo López", 18);
person.Show();

Console.WriteLine("---------");

Employee employee = new Employee("Fernando", "Carrillo López", 18, 500000, "Programmer");
employee.ShowEmployee();

/*
 * Notes:
 * The constructor of the base class is first called
 * In this case is Person
 */
