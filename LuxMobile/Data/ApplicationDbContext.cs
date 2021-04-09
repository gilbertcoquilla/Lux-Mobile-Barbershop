﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using LuxMobile.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace LuxMobile.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Services> Services { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<BookingDetails> BookingDetails { get; set; }
        public DbSet<Barber> Barbers { get; set; }
    }
}
