
namespace exam._4.linq.Models;
    public class Country
    {
     public int Id { get; set; }
    public string Name { get; set; }=null!;
    public List<City> Cities { get; set; }   
    }
