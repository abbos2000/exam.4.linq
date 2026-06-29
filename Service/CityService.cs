
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
}
