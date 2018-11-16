using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace WebAppEntity.Models
{
    
    public class Estudiante
    {

        [Required, Key]
        public int ID { get; set; }

        [Required, StringLength(50),Column(TypeName = "varchar")]
        public string Nombre { get; set; }

        //Aqui se usa Fluent API
        //Estamos diciendo qué tipo de dato de crearse en SQL SERVER
        [Required, StringLength(50), Column(TypeName = "varchar")]
        public string Apellido { get; set; }

        [Required, StringLength(13), Column(TypeName = "varchar"), Display(Name = "Cédula")]
        public string Cedula { get; set; }

        [Required, Column(TypeName = "char"), StringLength(1)]
        public string Sexo { get; set;  }

        [Column(TypeName = "date"), Display(Name ="Fecha Nacimiento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaNacimiento { get; set; }

        [Column(TypeName = "date"), Display(Name = "Fecha Ingreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaIngreso { get; set; }

        [Column(TypeName = "money")]
        public decimal Balance { get; set; }

        [Column(TypeName = "bit")]
        public bool Inactivo { get; set; }
    }
}

//TODO: Ejecutar los siguientes comandos
//TODO: Enable-Migrations 
//TODO: add-migration Initial
//TODO: update-database

//Ver Este link
//https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-aspnet-mvc4/adding-a-new-field-to-the-movie-model-and-table