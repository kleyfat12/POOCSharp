using Polymorphism;

int opcion = 0;
Console.WriteLine("What animal do you want?");
Console.WriteLine("1.- Dog");
Console.WriteLine("2.- Cat");
Console.WriteLine("3.- Fish");

opcion = Convert.ToInt32(Console.ReadLine());

/*
 * This is a concrete style programming
 * For each type of animal I have to implement a special treatment
 */
//if (opcion == 1)
//{
//    Dog dog = new Dog("Doggo");
//    dog.Move();
//}else if (opcion == 2)
//{
//    Cat cat = new Cat("Dixie");
//    cat.Move();
//}else if (opcion == 3)
//{
//    Fish fish = new Fish("Darwin");
//    fish.Move();
//}


/*
 * This is a general style programming
 * I implement the code thinking on the concept
 */
Animal animal = new Animal("MyAnimal");

if (opcion == 1)
{
    animal = new Dog("Doggo");
}
else if (opcion == 2)
{
    animal = new Cat("Dixie");
}
else if (opcion == 3)
{
    animal = new Fish("Darwin");
}

animal.Move();
