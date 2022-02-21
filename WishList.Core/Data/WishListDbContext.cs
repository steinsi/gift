using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WishList.Core.Models;

namespace WishList.Core.Data
{
    internal class WishListDbContext : DbContext
    {
     public DbSet <Wish> Wishes { get; set; }

    public DbSet <WishComment> WishComments { get; set; }
    


    }
}
