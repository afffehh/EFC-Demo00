using System;

namespace EFDemo00.Models;

public class School
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string Adress { get; set; }
    public ICollection<Students>? Students { get; set; }
}
