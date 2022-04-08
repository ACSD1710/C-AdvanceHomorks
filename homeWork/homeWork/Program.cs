// See https://aka.ms/new-console-template for more information



using homeWork.Classes;
using homeWork.Interface;
static void Catty(ICat cat)
{
    Console.WriteLine("Cats Eat");
    cat.Eat("Fish");
}
static void Dog(IDog dog)
{
    Console.Write("dog sayy");
    dog.Bark();
}


List<Animal> animals = new List<Animal>
{
    new Dog("Jackie", 4, "Labrador", "Middle", true),
    new Cat("Backie", 2, "Persian", "Middle", false ),
    new Dog("Richie", 1, "Terrier", "Little", false),
    new Cat("Totto", 10, "Siems", "Big", true),
    new Dog("Rambo", 6, "Haska", "Big", true)

};
foreach(var animal in animals) {


    if(animal.GetType() == typeof(Dog))
    {
        Console.WriteLine("======================");
        animal.Bark();
    }
    else
    {
        Console.WriteLine("======================");
        animal.Eat("Fish");
    }
}



Dog dog = new Dog("Jack", 2, "Pich", "Little", true);
Console.WriteLine("======================");
dog.Bark();
Console.WriteLine("======================");
dog.PrintAnimal();
Console.WriteLine("======================");
Dog(dog);
Console.WriteLine("======================");
Cat cat = new Cat("Janny", 2, "Wild", "big", true);
Console.WriteLine("======================");
cat.Eat("Burger");
Console.WriteLine("======================");
cat.PrintAnimal();
Console.WriteLine("======================");
Catty(cat);
Console.WriteLine("======================");
Console.ReadLine();
