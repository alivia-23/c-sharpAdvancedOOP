// Example file for Advanced C#: Object Oriented Programming by Joe Marini
// Using object and collection initializers

// TODO: Use the initializer syntax to create new objects
Dog dog = new Dog { Name = "Fido", Age = 4, IsTrained = true};
Cat cat = new Cat { Name = "Mr. Meowington", Age = 7, IsDeclawed = false};
System.Console.WriteLine($"Dog : {dog.Name}, {dog.Age}");
System.Console.WriteLine($"Cat : {cat.Name}, {cat.Age}");

// TODO: Initializers can be used on anonymous types
var pet = new {
    Name = "Charlie",
    Age = 5
};
System.Console.WriteLine($"Pet : {pet.Name}, {pet.Age}");

// TODO: Collections can also be initialized this way
// int[] nums = new int[] {1, 2, 3, 4, 5, 6};
// System.Console.WriteLine($"{nums.Length}");

// TODO: Initialize a collection with a set of objects
PetOwner owner = new PetOwner {
    Name = "Alivia Guin",
    Pets = new List<Pet> {
        new Dog {Name="Juno", Age=4},
        new Cat {Name="Lucy", Age=3},
        new Dog {Name="Max", Age=5}
    }
};

System.Console.WriteLine($"{owner.Name}'s Pets :");
foreach (Pet p in owner.Pets) {
    System.Console.WriteLine($"{p.GetType()} name is {p.Name}");
}

