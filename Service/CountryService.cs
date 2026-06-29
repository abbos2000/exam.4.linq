
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
    }
