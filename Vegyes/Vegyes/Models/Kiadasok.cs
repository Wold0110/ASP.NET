using System;
using System.Collections.Generic;

namespace Vegyes.Models;

public partial class Kiadasok
{
    public int Id { get; set; }

    public string? Ki { get; set; }

    public string? Mire { get; set; }

    public string? Mennyit { get; set; }
    public override string ToString() => $"Költő neve:{Ki}, Elköltött összeg:{Mennyit}, Erre: {Mire}";
}
