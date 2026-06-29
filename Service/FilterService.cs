
using exam._4.linq.Models;

namespace exam._4.linq.Service;

public class FilterService
{
    public List<Person> GetPeopleFromCitiesWithNameLength(List<Person> people, int length)
    {
        var res = people
            .Where(p => p.City.Name.Length == length)
            .ToList();
            return res;
    }
}
