﻿using Inheritance;

Person person = new Person("Fernando", "Carrillo López", 18);
person.Show();

Console.WriteLine("---------");

Employee employee = new Employee("Fernando", "Carrillo López", 18, 500000, "Programmer");
employee.ShowEmployee();

// I can not access to DNI
// Console.WriteLine(person.DNI);

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
 */