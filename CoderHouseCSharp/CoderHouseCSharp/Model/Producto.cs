﻿using System.Data.SqlTypes;

namespace CoderHouse_CSharp_API.Model
{
    public class Producto
    {
        public long Id { get; set; }
        public string Descripciones { get; set; }

        public int Costo { get; set; }
        public int PrecioVenta    { get; set; }    
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
    }
}