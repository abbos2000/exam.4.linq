
using exam._4.linq.Models;

namespace exam._4.linq.Service;

public class CityService
{
    public List<City> GetCitiesAboveAveragePopulation(List<Country> countries)
    {
        var res = countries
            .SelectMany(country =>
            {
                double average = country.Cities.Average(c => c.Population);

                return country.Cities
                    .Where(c => c.Population > average);
            })
            .ToList();
            return res;
    }

        public List<City> GetCitiesWithAlice(List<City> cities)
    {
        var res = cities
            .Where(c => c.People.Any(p =>
                p.Name.Equals("Alice", StringComparison.OrdinalIgnoreCase)))
            .ToList();
            return res;
    }

        public City GetCityWithMostPeopleInAgeRange(List<City> cities, int minAge, int maxAge)
    {
        var res = cities
            .OrderByDescending(c => c.People.Count(p => p.Age >= minAge && p.Age <= maxAge)).FirstOrDefault();
        return res;
    }
}
