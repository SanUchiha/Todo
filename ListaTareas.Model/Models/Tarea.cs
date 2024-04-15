using System;
using System.Collections.Generic;

namespace ListaTareas.Model.Models;

public partial class Tarea
{
    public int IdTarea { get; set; }

    public string? NombreTarea { get; set; }

    public bool? Completada { get; set; }
}
