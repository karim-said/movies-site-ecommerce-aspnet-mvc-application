﻿using Microsoft.EntityFrameworkCore; 

namespace MoveisSite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base (options)
        {

        }
    }
}
