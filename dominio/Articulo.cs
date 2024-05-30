﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }// para hacer las relaciones entre tablas
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion {  get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; } //equivalente de tipo money: decimal

        public Articulo() { }


    }

}