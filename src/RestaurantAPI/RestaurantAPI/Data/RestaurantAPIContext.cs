using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PointOfSale.Models;

namespace RestaurantAPI.Data
{
    public class RestaurantAPIContext : DbContext
    {
        public RestaurantAPIContext (DbContextOptions<RestaurantAPIContext> options)
            : base(options)
        {
        }

        public DbSet<PointOfSale.Models.Item> Item { get; set; } = default!;
    }
}
