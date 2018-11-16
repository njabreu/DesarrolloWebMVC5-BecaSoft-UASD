# DesarrolloWebMVC5-BecaSoft-UASD

Este proyecto ha sido creado para el Diplomado Desarrollo Web con C# de la Universidad Autónoma de Santo Domingo.

Para utilizar este proyecto debe crear una base de datos en SQL SERVER y colocar la información de conexión al servidor
de SQL Server en el archivo web.config. <br />
Estos son los valores que están en la cadena de conexión: <br/>
Initial Catalog = Diplomado <br/>
User ID = sa <br/>
Password = Diplomado1234 <br/>

Aquí está la sección del Web.Config del proyecto donde se deben cambiar los datos de conexión :

 &lt;connectionStrings&gt; <br />
  &nbsp; &nbsp; &nbsp; &lt;add name="connStr" connectionString="Data Source=<strong>LOCALHOST\SQLEXPRESS</strong>;
  Initial Catalog=<strong>Diplomado</strong>;Integrated Security=False;User ID=<strong>sa</strong>;Password=<strong>diplomado1234</strong>;" providerName="System.Data.SqlClient" /&gt; <br/>
  &lt;connectionStrings/&gt;

Luego desde la consola de Nuget ejecutar los siguientes comandos: <br />
PM> Enable-Migrations  <br/>
PM> add-migration Initial <br/>
PM> update-database <br/>
<br/>

Si todo resultó sin problemas, ejecutar el proyecto y elegir la opción Estudiantes del menú principal.
