

using Exerise01.Base;
using Exerise01.Pets;



PetsDb<Cat> Cats = new PetsDb<Cat>();
PetsDb<Dog> Dogs = new PetsDb<Dog>();
PetsDb<Fish> Fishes = new PetsDb<Fish>();

Cats.Insert(new Cat() { Name = "Oto", Age = 1, Lazy = false, LivesLeft = 10, Type = "Persian" });
Cats.Insert(new Cat() { Name = "Jilly", Age = 2, Lazy = true, LivesLeft = 15, Type = "Assian" });
Cats.Insert(new Cat() { Name = "Ricchie", Age = 12, Lazy = true, LivesLeft = 5, Type = "Freanch" });

Dogs.Insert(new Dog() { Name = "Jackie", Age = 1, FavoriteFood = "Bones", GoodBoy = true, Type = "Labrador" });
Dogs.Insert(new Dog() { Name = "Elvis", Age = 1, FavoriteFood = "Meet", GoodBoy = true, Type = "Goled RetRiver" });
Dogs.Insert(new Dog() { Name = "Bayden", Age = 1, FavoriteFood = "Meet", GoodBoy = false, Type = "Doga" });

Fishes.Insert(new Fish() { Name = "Emo", Age = 1, Color = "Black - White", Size = 2, Type = "Scallar" });
Fishes.Insert(new Fish() { Name = "Demo", Age = 2, Color = "Yellow", Size = 5, Type = "Golden Fish" });
Fishes.Insert(new Fish() { Name = "Imo", Age = 1, Color = "Blue - Green", Size = 4, Type = "Discus" });




    Console.WriteLine("Welcome to the Pets Store this is our Pets");
Console.WriteLine("CATS");
    Cats.PrintPets();
Console.WriteLine("DOGS");
    Dogs.PrintPets();
Console.WriteLine("FISHES");
    Fishes.PrintPets();

while (true) {
 
    try
    {
        Console.WriteLine("What kind of pet do you like to Buy:");
        Console.WriteLine("1) Inser 1 for CATS");
        Console.WriteLine("2) Inser 2 for DOGS");
        Console.WriteLine("3) Inser 3 for FISHES");
        bool userInput = int.TryParse(Console.ReadLine(), out int userInput1);
        if (!userInput && userInput1 < 1 || userInput1 > 3)
        {
            throw new Exception("asdasd");
        }
        
        Console.WriteLine("Insert name");
        string petName = Console.ReadLine();

        if (userInput1 == 1)
        {
            Cats.BuyPet(petName);
        }
        else if (userInput1 == 2)
        {
            Dogs.BuyPet(petName);
        }
        else
        {
            Fishes.BuyPet(petName);
        }
        
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    
    
}









Console.ReadLine();
