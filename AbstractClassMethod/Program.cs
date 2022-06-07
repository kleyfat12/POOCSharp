using AbstractClassMethod;

// Abstract class can not be instantiated
// Person person = new Person();

Person person = new Employee("Fernando", "Carrillo", 18, "Programmer", 500000);
person.Show();

/*
 * Notes:
 * The polymorphism is conserved
 * 
 * All the sub classes of an abstract class 
 * have a responsibility to implement abstract methods
 */