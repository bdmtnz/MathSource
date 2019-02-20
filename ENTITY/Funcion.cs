﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Funcion
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Contenido { get; set; }
        public int Dominio { get; set; }
        public int Rango { get; set; }
        public int Continuidad { get; set; }
        public int Crecimiento { get; set; }
        public string Maximo { get; set; }
        public string Minimo { get; set; }
        public List<string> CortesAbscisas { get; set; }
        public List<string> CortesOrdenadas { get; set; }
        public List<string> Partes { get; set; }

        public Funcion(string Id, string Nombre, string Contenido)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Contenido = Contenido;
        }

    }
}
