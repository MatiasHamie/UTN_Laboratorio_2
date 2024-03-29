﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PatenteStringExtension
    {
        public const string patente_vieja = "^[A-Z]{3}[0-9]{3}$";
        public const string patente_mercosur = "^[A-Z]{2}[0-9]{3}[A-Z]{2}$";

        public static Patente ValidarPatente(this string str)
        {
            Patente p;
            Regex rgx_v = new Regex(PatenteStringExtension.patente_vieja);
            Regex rgx_n = new Regex(PatenteStringExtension.patente_mercosur);

            if (rgx_v.IsMatch(str))
            {
                p = new Patente(str, Patente.Tipo.Vieja);
            }
            else if (rgx_n.IsMatch(str))
            {
                p = new Patente(str, Patente.Tipo.Mercosur);
            }
            else
            {
                string s = string.Format("{0} no cumple el formato.", str);
                throw new PatenteInvalidaException(s);
            }

            return p;
        }

        

    }
}
