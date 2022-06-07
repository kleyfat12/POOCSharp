using Inheritance;

Person person = new Person("Fernando", "Carrillo López", 18);
person.Show();

Console.WriteLine("---------");

Employee employee = new Employee("Fernando", "Carrillo López", 18, 500000, "Programmer");
employee.Show();

// I can not access to DNI
// Console.WriteLine(person.DNI);
Console.WriteLine("---------");

// Checking polymorphism

Person myPerson = new Employee("Fernando", "Carrillo", 18, 500000, "Programmer");

// The person method is called
myPerson.Show();

// The employee method is called
myPerson.BetterShow();

/*
 * Notes:
 * The constructor of the base class is first called
 * In this case is Person
 * 
 * Protected access:
 * Allows child classes to have access but no one else
 * 
 * sealed:
 * Prevents the class from having sub classes
 * Also prevents override on methods
 * 
 * new on methods:
 * Allows us to override method but we lost polymorphism
 */
