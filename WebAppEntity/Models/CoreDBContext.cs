using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.Entity;

namespace WebAppEntity.Models
{
    public class CoreDBContext : DbContext
    {

        public DbSet<Estudiante> Estudiantes { get; set; } //tblEstudiantes

        public CoreDBContext()
           : base("connStr") //Esto sirve para indicar como se llama el connectionString de esta clase.
                             //debe existir un connectionStrings con el nombre de connStr en el area de <connectionStrings> del web.config
                             /* 
                              En este caso se conecta a la Base de Datos Diplomado -> Initial Catalog=Diplomado
                              El usuario administrador para autenticación de SQL es -> User ID=sa
                              La contraseña es -> Password = diplomado
                              La dirección del servidor es Data Source=LOCALHOST\SQLEXPRESS
                              Sustituir estos valores por los apropiados en cada caso
                              <connectionStrings>
                                  <add name = "connStr" connectionString="Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=Diplomado;Integrated Security=False;User ID=sa;Password=diplomado00;" providerName="System.Data.SqlClient" />
                                </connectionStrings>

                           */
                             // Para hacer que el Entity Framework cargue los modelos a las tablas de la base de datos Diplomado usar la siguiente secuencia de comandos
                             // Desde la Consola de Nuget
                             // Enable-Migrations
                             // add-migration Initial
                             // update-database
        {
            this.Configuration.LazyLoadingEnabled = true; //
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Asigna el nombre de la tabla
            modelBuilder.Entity<Estudiante>().ToTable("tblEstudiantes"); //Se le indica que nombre asignar a la tabla. Si no se especifica le pone el nombre de la clase.
        }
    }
}