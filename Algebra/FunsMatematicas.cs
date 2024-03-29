﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;

namespace ALGEBRA
{
    public class Eulers : AFuns
    {
        public override string Nombre => "EULER";
        public override string Simbolo => "e";
        public override string SimboloExtendido => "e^{";
        private string Valor => "2.71828";
        private string ArgDefecto => "1";
        public override char Op => '{';
        public override char Cl => '}';
        PotenciaEntera Potencia = new PotenciaEntera();
        double number;

        public Eulers() {

            Argumento = ArgDefecto;
            Potencia = new PotenciaEntera(Simbolo, Argumento);
            Contenido = Simbolo + Potencia.Simbolo + Argumento;
            Foco = SimboloExtendido + ArgDefecto + Cl;
            Coeficiente = "1";
            Operar();

        }

        public Eulers(string Expresion)
        {

            if (Proceso.IsAgrupate(Expresion))
                Expresion = Proceso.DescorcharA(Expresion);

            Contenido = Expresion;
            ObtenerArgumento();
            ObtenerCoeficiente();
            Operar();

        }

        protected override void ObtenerCoeficiente()
        {
            if (Contenido.Contains(SimboloExtendido + Argumento + Cl))
                Foco = SimboloExtendido + Argumento + Cl;
            else
                Foco = Simbolo + Potencia.Simbolo + Argumento;

            Coeficiente = Contenido.Replace(Foco, "1");
            Coeficiente = Proceso.ParentesisClear(new ProductoEntero(Coeficiente).Result);
            if (Coeficiente.Equals(""))
                Coeficiente = "1";
        }

        protected override void ObtenerArgumento()
        {
            int Inicial = 0;
            int Final = 0;

            if (Contenido.Contains(SimboloExtendido))
            {
                Inicial = Contenido.IndexOf(SimboloExtendido) + 3;
                Final = Contenido.LastIndexOf(Cl) - Inicial;
            }
            else
            {
                //HACER INTELIGENTE LA TOMA DEL ARGUMENTO (HASTA QUE SE FINAL O ENCUENTRE OTRA FUNCION O TAL VEZ OTRO OPERADOR)
                Inicial = Contenido.IndexOf(Simbolo) + 2;
                Final = Contenido.Length - Inicial;
            }
            
            Argumento = Contenido.Substring(Inicial, Final);
        }

        protected override void Operar()
        {
            Potencia = new PotenciaEntera(Foco);
            if (double.TryParse(Argumento, out number))
                Result = new PotenciaEntera(Valor, Argumento).Result;
            else
                Result = new ProductoEntero(Coeficiente,Potencia.Result).Result;
        }

        

    }

    public class LogNaturales : AFuns
    {
        public override string Nombre => "LOG NATURAL";
        public override string Simbolo => "ln";
        public override string SimboloExtendido => "ln<";
        public override char Op => '<';
        public override char Cl => '>';
        private string ArgDefecto => "1";
        public double ModuloCancelativo => 0;
        double number;

        public LogNaturales()
        {
            Argumento = ArgDefecto;
            Foco = SimboloExtendido + ArgDefecto + Cl;
            Coeficiente = "1";
            Contenido = Foco;
        }

        public LogNaturales(string Expresion)
        {
            if (Proceso.IsAgrupate(Expresion))
                Expresion = Proceso.DescorcharA(Expresion);

            Contenido = Expresion;
            ObtenerArgumento();
            ObtenerCoeficiente();
            Operar();
        }

        protected override void ObtenerCoeficiente()
        {
            Foco = SimboloExtendido + Argumento + Cl;
            Coeficiente = Contenido.Replace(Foco, "1");
            Coeficiente = Proceso.ParentesisClear(new ProductoEntero(Coeficiente).Result);
            if (Coeficiente.Equals(""))
                Coeficiente = "1";
        }

        protected override void ObtenerArgumento()
        {
            int Inicial = Contenido.IndexOf(SimboloExtendido) + 3;
            int Final = Contenido.LastIndexOf(Cl) - Inicial;
            Argumento = Contenido.Substring(Inicial, Final);
        }

        protected override void Operar()
        {
            bool A, B, C;
            A = double.TryParse(Argumento, out number);
            B = Argumento.Equals(ArgDefecto);
            C = Argumento.Equals($"{ModuloCancelativo}");

            if (C)
                Result = "Math ERROR";
            else if (A)
            {
                double Arg = double.Parse(Argumento);

                if (Arg < 1)
                    Result = "Math ERROR";
                else
                    Result = $"{Math.Log(Arg)}";
            }
                
            else if (B)
                Result = $"{ModuloCancelativo}";
            else
                Result = new ProductoEntero(Coeficiente,Foco).Result;
        }

        
    }
}
