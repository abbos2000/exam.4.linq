
using exam._4.linq.Models;

namespace exam._4.linq.Service;

public class SearchService
{
    public List<City> GetCitiesWithAlice(List<City> cities)
    {
        var res = cities
            .Where(c => c.People.Any(p =>
                p.Name.Equals("Alice", StringComparison.OrdinalIgnoreCase)))
            .ToList();
            return res;
    }
}
