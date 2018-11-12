using Microsoft.EntityFrameworkCore;
using vega.Models;

/* A car's make is the brand of the vehicle, while the model 
refers to the name of a car product and sometimes a range of products. 
For example, Toyota is a car make and Camry is a car model. */
namespace vega.Persistence
{
    public class VegaDbContext :DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Feature> Features { get; set; }
        public DbSet<Make> Makes { get; set; }
        //Note: we don't need to add a model class b/c EF sees the realtionship and will discover 'model'
    }
}