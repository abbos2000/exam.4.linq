
using exam._4.linq.Models;

namespace exam._4.linq.Service;

public class PopulationService
{
    public List<Person> GetPeopleFromLargestCity(List<Country> countries)
    {
        var res = countries
            .SelectMany(country =>
            {
                var city = country.Cities
                    .OrderByDescending(c => c.Population)
                    .First();

                return city.People;
            })
            .ToList();
            return res;
    }
}
