using Microsoft.EntityFrameworkCore;
using lotusApi.Models;

namespace lotusApi.Data{
    public class DataContext: DbContext{

        public DataContext(DbContextOptions<DataContext> options): base(options){
            
        }

        public DbSet<Categoria> Categorias {get; set;}

    }
}