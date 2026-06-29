
using exam._4.linq.Models;

namespace exam._4.linq.Service;

public class PersonService
{
    public List<Person> GetPeopleFromBigCities(List<Person> people)
    {
        var res = people
            .Where(p => p.City.Population > 3000000)
            .ToList();
        return res;
    }
}
