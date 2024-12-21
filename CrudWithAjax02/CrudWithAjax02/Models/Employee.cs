using System;
using System.Collections.Generic;

namespace CrudWithAjax02.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string State { get; set; } = null!;

    public string City { get; set; } = null!;

    public int Salary { get; set; }
}
