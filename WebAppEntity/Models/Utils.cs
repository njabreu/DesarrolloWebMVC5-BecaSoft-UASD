using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppEntity.Models
{
    /// <summary>
    /// Clase Utils 
    /// Para todo lo que se de utilidad en el sistema.
    /// </summary>
    public class Utils
    {
        /// <summary>
        /// Retorna una listado de sexo: Masculino y Femenino
        /// </summary>
        /// <returns>Un arreglo de SelectListItem</returns>
        public static SelectListItem[] GetListadoSexo()
        {
            SelectListItem[] lista =
            {
                new SelectListItem { Text = "Masculino", Value = "M" },
                new SelectListItem { Text = "Femenino", Value =  "F" },
           };
            return lista;
        }
    }
}