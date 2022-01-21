#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebChayThu.Models;

namespace WebChayThu.Data
{
    public class WebChayThuContext : DbContext
    {
        public WebChayThuContext()
        {
        }

        public WebChayThuContext (DbContextOptions<WebChayThuContext> options)
            : base(options)
        {
        }

        public DbSet<WebChayThu.Models.User> User { get; set; }
        
    }
}
