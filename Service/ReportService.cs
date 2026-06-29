
using exam._4.linq.Models;

namespace exam._4.linq.Service;

public class ReportService
{
    public List<object> GetPeopleWithCityAndCountry(List<Person> people)
    {
        var res =  people
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
}
