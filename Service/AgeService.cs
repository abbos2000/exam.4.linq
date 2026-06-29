
using exam._4.linq.Models;

namespace exam._4.linq.Service;
public class AgeService
{
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
