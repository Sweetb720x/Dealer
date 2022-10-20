using System;
using System.Collections.Generic;

namespace Entidades
{
    public partial class Tauto
    {
        public int Id { get; set; }
        public string? Marca { get; set; }
        public string? Modelo { get; set; }
        public string? Color { get; set; }
        public int? Año { get; set; }
        public string? Tipo { get; set; }
        public string? Transmicion { get; set; }
        public decimal? Costo { get; set; }
        public string? Foto { get; set; }
        public string? Descripcion { get; set; }
    }
}
