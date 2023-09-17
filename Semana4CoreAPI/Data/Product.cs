using System;
using System.Collections.Generic;

namespace Semana4CoreAPI.Data;

public partial class Product
{
    public int IdProduct { get; set; }

    public string? Description { get; set; }

    public decimal? UnitPrice { get; set; }
}
