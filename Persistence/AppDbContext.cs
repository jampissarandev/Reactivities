using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class AppDbContext(DbContextOptions option) : DbContext(option)
{
    public required DbSet<Activity> Activities { get; set; }
}
