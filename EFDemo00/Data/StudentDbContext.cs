using System;
using EFDemo00.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDemo00.Data;

public class StudentDbContext : DbContext
{
    public DbSet<School> Schools { get; set;} = null!;
    public DbSet<Students> Students { get; set;} = null!;
    public DbSet<Course> Courses{ get; set;} = null!;
    public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }
}
