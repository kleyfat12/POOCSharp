using Casting;

Person person = new Employee();

/*
 * Even though the variable is actually of the "Employee" type,
 * I can not access to EmployeeSayHello method
 */
// person.EmployeeSayHello();

/*
 * We need to cast to Employee
 */
((Employee)person).EmployeeSayHello();

/*
 * object is the super class
 */
object person2 = new Employee();
((Employee)person2).EmployeeSayHello();

Console.WriteLine(person is object);
Console.WriteLine(person is Employee);
Console.WriteLine(person is Person);

/*
 * Notes:
 * I only can cast from the more specific to the more generic
 * Example: I can cast from Employee to Person
 */