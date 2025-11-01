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
