We created an ASP.NET Core Web API project, which we named Manga.Services.

<a>
        <img src="creacion.png" alt="ASP.NET Core Web API project" width="600" height="600"/>
  </a>

We click on IIS Express to run the project.

<a>
        <img src="run.png" alt="run the project" width="600" height="600"/>
  </a>

The following window appears. We click “Yes,” and another warning window shows up, to which we also click “Yes.”

<a>
        <img src="certificado.png" alt="certificate" width="600" height="600"/>
  </a>

We go to the project and right-click on “Manage NuGet Packages.”

<a>
        <img src="paquetes.png" alt="Packages" width="600" height="600"/>
  </a>

We install AutoMapper version 10.0.0. We also install AutoMapper.Extensions.Microsoft.DependencyInjection version 11.0.0 and update AutoMapper to version 11.0.0. We use AutoMapper to map the DTOs to the Models, and DependencyInjection to inject the Services into the Interfaces.

<a>
        <img src="automapper.png" alt="AutoMapper" width="600" height="600"/>
  </a>

We install EntityFrameworkCore.SqlServer version 5.0.15 and Microsoft.EntityFrameworkCore.Tools. Entity Framework allows us to modify and access the database according to the migrations we create. The migrations take into account the models we create or modify in the project, which are stored in the "Models" folder.


<a>
        <img src="entities.png" alt="Entities" width="600" height="600"/>
  </a>

From Manga.Services, we right-click and add a new folder called Context, where we create a new class named "MangaDbContext" that inherits from DbContext (see full code in the appendix). This class is used to configure the database connection and define the tables we have.

<a>
        <img src="services.png" alt="Context" width="600" height="600"/>
  </a>

Next, we go to the Startup class and add the DbContext service to configure the connection to our database (in this case, a local one).

<a>
        <img src="connection.png" alt="Connetion" width="600" height="600"/>
  </a>

We go to appsettings.json and enter all the necessary information to establish the database connection.

<a>
        <img src="connection2.png" alt="Connetion 2" width="600" height="600"/>
  </a>

We create the folder that will contain the models (the “Anime” and “User” classes).

<a>
        <img src="modelos.png" alt="Models" width="600" height="600"/>
  </a>

We go to Tools → NuGet Package Manager → Package Manager Console, and from there we create the tables in our database.

<a>
        <img src="Tablas.png" alt="Tables" width="600" height="600"/>
  </a>

In the console, we type: add-migration Tablas Iniciales

<a>
        <img src="consola.png" alt="Console" width="600" height="600"/>
  </a>

We create the folder that will contain the DTOs (Data Transfer Objects), where we add the “AnimeDto” and “UserDto” classes to transfer data between the models and controllers.

<a>
        <img src="dtos.png" alt="DTOs" width="600" height="600"/>
  </a>

In Manga.Services, we create a new class called “MappingConfig” (see code in the appendix) to map the DTOs to the models.

<a>
        <img src="mapeo.png" alt="Mapping" width="600" height="600"/>
  </a>

We go to the Startup class and add three lines of code in the ConfigureServices method to complete the mapper configuration.

<a>
        <img src="configuracion.png" alt="Configuration" width="600" height="600"/>
  </a>

We create a new folder called “Repository” to store the “IAnimeRepository” interface and manage the functions we define (which will be injected into the constructors) (see full code in the appendix).

<a>
        <img src="repositorio.png" alt="Repository" width="600" height="600"/>
  </a>

Creamos la clase “AnimeRepository” que implementa la interfaz creada en el apartado anterior. Aquí implementamos los métodos definidos en la interfaz (ver código en el anexo).

<a>
        <img src="clase.png" alt="Clase" width="600" height="600"/>
  </a>

Next, we return to the Startup class and add another line of code. We perform dependency injection using services.AddScoped, injecting AnimeRepository into IAnimeRepository.

<a>
        <img src="inyeccion.png" alt="Injection" width="600" height="600"/>
  </a>

We go to the Controllers folder and add a blank API controller called “AnimeController”. Here, we define the endpoints and specify what each one does when a request is made (see code in the appendix).

<a>
        <img src="controladores.png" alt="Controller" width="600" height="600"/>
  </a>

Next, we go to the DTO folder and create the ResponseDto class to standardize all responses.

<a>
        <img src="respuesta.png" alt="Responses" width="600" height="600"/>
  </a>

Finally, we repeat the same process for Users, and with that, we complete our API.

<a>
        <img src="api.png" alt="API" width="600" height="600"/>
  </a>
