
using exam._4.linq.Models;

namespace exam._4.linq.Service;

public class CountryService
{
    public List<City> GetLargestCityInEachCountry(List<Country> countries)
    {
        var res = countries
            .Select(c => c.Cities
                .OrderByDescending(city => city.Population)
                .First())
            .ToList();
        return res;
    }

    public List<object> GetPeopleWithCityAndCountry(List<Person> people)
    {
        var res = people
            .Select(p => new
            {
                Person = p.Name,
                City = p.City.Name,
                Country = p.City.Country.Name
            })
            .Cast<object>()
            .ToList();
        return res;
    }

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
