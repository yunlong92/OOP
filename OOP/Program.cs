namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Person person = new Person();

            // Instansiera PersonHandler och skapa personer
            PersonHandler handler = new PersonHandler();

            try
            {
                // Skapa personer via PersonHandler
                Person person1 = handler.CreatePerson(25, "John", "Doe", 180.5, 75.3);
                Person person2 = handler.CreatePerson(30, "Anna", "Smith", 165.2, 65.0);

                // Sätta ålder och namn för en person
                handler.SetAge(person1, 26);
                handler.SetNames(person2, "Ann", "Johnson");

                // Hämta och skriv ut information om personerna
                Console.WriteLine($"Person 1: {handler.GetFullName(person1)}, Age: {handler.GetAge(person1)}, Height: {handler.GetHeightAndWeight(person1).Item1} cm, Weight: {handler.GetHeightAndWeight(person1).Item2} kg");
                Console.WriteLine($"Person 2: {handler.GetFullName(person2)}, Age: {handler.GetAge(person2)}, Height: {handler.GetHeightAndWeight(person2).Item1} cm, Weight: {handler.GetHeightAndWeight(person2).Item2} kg");

                // Skapa en lista av UserErrors och skriv ut felmeddelanden
                List<UserError> userErrors = new List<UserError>
                {
                    new NumericInputError(),
                    new TextInputError(),
                    new SpecialCharacterError(), 
                    new EmptyFieldError(),       
                    new OutOfRangeError()        
                };

                // Skriv ut samtliga UserErrors UEMessage() genom en foreach loop
                foreach (var error in userErrors)
                {
                    Console.WriteLine(error.UEMessage());
                }

                // Testar subklasser och polymorfism
                List<Animal> animals = new List<Animal>
                {
                    new Horse("Shadowfax", 500, 7, 75),
                    new Dog("Buddy", 30, 5, "Labrador"),
                    new Hedgehog("Spiky", 1, 3, 5000),
                    new Worm("Slither", 0.1, 1, false),
                    new Pelican("Pelican Pete", 15, 4, 2.5, 30),
                    new Flamingo("Fancy", 10, 6, 1.5, "Pink"),
                    new Swan("Grace", 12, 5, 2, true),
                    new Wolfman("Jacob", 85, 25, 12)
                };

                // Skriv ut vilka djur som finns i listan och deras ljud
                foreach (var animal in animals)
                {
                    Console.WriteLine($"{animal.Name} makes a sound:");
                    animal.DoSound();

                    // Kontrollera om djuret är av typen IPerson och anropa Talk()
                    if (animal is IPerson person)
                    {
                        person.Talk();
                    }
                }

                // Skapa en lista för hundar
                List<Dog> dogs = new List<Dog>
                {
                    new Dog("Rex", 35, 4, "German Shepherd"),
                    new Dog("Bella", 22, 3, "Poodle")
                };

                // Lägga till en häst i listan för hundar fungerar inte eftersom listan är av typen Dog

                // Skriv ut samtliga Animals Stats() genom en foreach loop
                Console.WriteLine("\nAnimal Stats:");
                foreach (var animal in animals)
                {
                    Console.WriteLine(animal.Stats());
                }

                // Skriv ut Stats() för alla hundar
                Console.WriteLine("\nDog Stats:");
                foreach (var animal in animals)
                {
                    if (animal is Dog dog)
                    {
                        Console.WriteLine(dog.Stats());
                    }
                }

                // Komma åt Dog-specialmetoden genom type-cast
                Console.WriteLine("\nSpecial Method for Dogs:");
                foreach (var animal in animals)
                {
                    if (animal is Dog dog)
                    {
                        Console.WriteLine(dog.DogSpecialMethod());
                    }
                }
            }
            catch (ArgumentException ex)
            {
                // Hantera undantag
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
