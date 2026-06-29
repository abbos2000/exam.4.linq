
using exam._4.linq.Models;

namespace exam._4.linq.Service;

public class StatisticsService
{
    public List<Person> GetOldestPersonInEachCity(List<City> cities)
    {
        var res =  cities
        .Select(c => c .People.OrderByDescending(p => p.Age)
        .First())
        .ToList();
        return res;
    }
}
