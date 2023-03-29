using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//para hacer referencia a Dbcontext y a Dbset se requiere hacer uso de: 
using System.Data.Entity;
//faltara instalar algo? paquete Nuget de entity framework????


namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext 
    {
    public DbSet<Movie> Movies { get; set; }
    }

}