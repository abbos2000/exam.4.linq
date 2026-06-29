

using exam._4.linq.Models;
using exam._4.linq.Service;

var tajikistan = new Country { Id = 1, Name = "Tajikistan" };
        var usa = new Country { Id = 2, Name = "USA" };
        var dushanbe = new City
        {
            Id = 1,
            Name = "Dushanbe",
            Population = 1200000,
            Country = tajikistan
        };
        var khujand = new City
        {
            Id = 2,
            Name = "Khujand",
            Population = 500000,
            Country = tajikistan
        };
        var newYork = new City
        {
            Id = 3,
            Name = "New York",
            Population = 8500000,
            Country = usa
        };
        tajikistan.Cities = new List<City> { dushanbe, khujand };
        usa.Cities = new List<City> { newYork };
        var people = new List<Person>
        {
            new Person { Id = 1, Name = "Alice", Age = 25, City = dushanbe },
            new Person { Id = 2, Name = "Idris", Age = 40, City = dushanbe },
            new Person { Id = 3, Name = "Soni tu durust mii", Age = 18, City = khujand },
            new Person { Id = 4, Name = "alice", Age = 30, City = newYork },
            new Person { Id = 5, Name = "Tom", Age = 55, City = newYork }
        };
        dushanbe.People = people.Where(p => p.City == dushanbe).ToList();
        khujand.People = people.Where(p => p.City == khujand).ToList();
        newYork.People = people.Where(p => p.City == newYork).ToList();
        var countries = new List<Country> { tajikistan, usa };
        var cities = new List<City> { dushanbe, khujand, newYork };
        var personService = new PersonService();
        var result = personService.GetPeopleFromBigCities(people);
        Console.WriteLine("People from cities with population > 3 million:");
        foreach (var p in result)
        {
            Console.WriteLine($"{p.Name} - {p.City.Name}");
        }
