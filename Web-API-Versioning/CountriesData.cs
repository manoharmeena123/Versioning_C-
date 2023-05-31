using Web_API_Versioning.Models.Domain;

namespace Web_API_Versioning
{
    public static class CountriesData
    {
        public static List<Country> Get()
        {
            var countries = new[]
            {
                 new {Id =1, Name ="United State"},
                 new {Id =2, Name ="Madhya State"},
                 new {Id =3, Name ="Rajya State"},
                 new {Id =4, Name ="West State"},
                 new {Id =5, Name ="North State"},
                 new {Id =6, Name ="South State"},
                 new {Id =7, Name ="NorthSougth State"},
                 new {Id =8, Name ="Easyt State"},
                 new {Id =9, Name ="NorthWest State"},
                 new {Id =10, Name ="EastNorth State"},
            };
            return countries.Select(c => new Country { Id = c.Id, Name = c.Name }).ToList();

        }
       
    }
}