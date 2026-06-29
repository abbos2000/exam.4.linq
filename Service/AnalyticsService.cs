
using exam._4.linq.Models;

namespace exam._4.linq.Service;

public class AnalyticsService
{
    public City GetCityWithMostPeopleInAgeRange(List<City> cities, int minAge, int maxAge)
    {
        var res = cities
            .OrderByDescending(c => c.People.Count(p => p.Age >= minAge && p.Age <= maxAge)).FirstOrDefault();
        return res;
    }
}
