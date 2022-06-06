using StaticAttributes;

Employee fer = new Employee("Fer");
Employee cesar = new Employee("Cesar");
Employee patrick = new Employee("Patrick");

/*
 * As the attribute is shared, counter is incremented 
 * with each new instance and the value is assigned to Number
 */
Console.WriteLine(fer.Number);
Console.WriteLine(cesar.Number);
Console.WriteLine(patrick.Number);