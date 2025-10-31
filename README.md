# My-Manga-Collection
A manga collection app for fans to organize and track their physical or digital volumes. With long-running series like One Piece, collectors need an easy way to manage their collections, stay updated, and follow their favorite titles when anime releases lag behind manga.

 <a>
        <img src="portada.png" alt="portada" width="600" height="600"/>
  </a>

General Objective:

<li> Use Visual Studio to develop a desktop application that enables users to manage their manga collection: search, register, edit, and delete manga entries. </li>

<br>

Specific Objectives:

<li> Create a user registration system for those who wish to access the application. </li>

<li> Implement a login window for authenticated user access. </li>

<li> Develop a management system that ensures security and prevents execution errors that could crash the application. </li>

<li> Design a user interface that is functional, user-friendly, and visually appealing. </li>

The class diagram describes the structure of a program through its component classes, their attributes, operations, and the relationships between classes.

 <a>
        <img src="diagrama.png" alt="class diagram" width="600" height="600"/>
  </a>

The use case diagram is a graphical description of the system's behavior.

 <a>
        <img src="casos.png" alt="use case diagram" width="600" height="600"/>
  </a>

Here we will look at the entity-relationship diagram of the database that was created. The components can be represented through an entity-relationship diagram.

 <a>
        <img src="entidad-relacion.png" alt="entity-relationship diagram" width="600" height="600"/>
  </a>

Navigation Map

 <a>
        <img src="mapa.png" alt="Navigation Map" width="600" height="600"/>
  </a>

When the program is launched, the login window opens. The application's logo appears in the upper left corner. The window includes two textboxes for entering the username and password, and below them, a checkbox to show or hide the password. This first part of the application also allows users to click the "Register" button, which opens another similar window where users can create an account to manage their manga collections.

 <a>
        <img src="login.png" alt="Log in" width="600" height="600"/>
  </a>

When the "Log in" button is pressed, the application checks the username and password in the database. If they match, access to the next window is granted; otherwise, a MessageDialog appears informing the user that their credentials are incorrect.

<a>
        <img src="login2.png" alt="login error" width="600" height="600"/>
  </a>

