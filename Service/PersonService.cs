
using exam._4.linq.Models;

namespace exam._4.linq.Service;

public class PersonService
{
    public List<Person> GetPeopleFromBigCities(List<Person> people)
    {
        var res = people
            .Where(p => p.City.Population > 3000000)
            .ToList();
        return res;
    }

        public List<Person> GetOldestPersonInEachCity(List<City> cities)
    {
        var res =  cities
        .Select(c => c .People.OrderByDescending(p => p.Age)
        .First())
        .ToList();
        return res;
    }

        public List<Person> GetPeopleFromCitiesWithNameLength(List<Person> people, int length)
    {
        var res = people
            .Where(p => p.City.Name.Length == length)
            .ToList();
            return res;
    }

      public List<Person> GetYoungestPersonInEachCountry(List<Country> countries)
    {
        var res = countries
            .Select(country =>
                country.Cities
                    .SelectMany(c => c.People)
                    .OrderBy(p => p.Age)
                    .First())
            .ToList();
            return res;
    }
}
