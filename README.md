# My-Manga-Collection
A manga collection app for fans to organize and track their physical or digital volumes. With long-running series like One Piece, collectors need an easy way to manage their collections, stay updated, and follow their favorite titles when anime releases lag behind manga.

 <a>
        <img src="portada.png" alt="portada" width="600" height="600"/>
  </a>

##General Objective:

<li> Use Visual Studio to develop a desktop application that enables users to manage their manga collection: search, register, edit, and delete manga entries. </li>

<br>

##Specific Objectives:

<li> Create a user registration system for those who wish to access the application. </li>

<li> Implement a login window for authenticated user access. </li>

<li> Develop a management system that ensures security and prevents execution errors that could crash the application. </li>

<li> Design a user interface that is functional, user-friendly, and visually appealing. </li>

### Class diagram

The class diagram describes the structure of a program through its component classes, their attributes, operations, and the relationships between classes.

 <a>
        <img src="diagrama.png" alt="class diagram" width="600" height="600"/>
  </a>

### Use case diagram

The use case diagram is a graphical description of the system's behavior.

 <a>
        <img src="casos.png" alt="use case diagram" width="600" height="600"/>
  </a>

### Entity-relationship diagram

Here we will look at the entity-relationship diagram of the database that was created. The components can be represented through an entity-relationship diagram.

 <a>
        <img src="entidad-relacion.png" alt="entity-relationship diagram" width="600" height="600"/>
  </a>

### Navigation Map

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

In this window, there are two textboxes: one for entering the username and another for entering the password. Below them, there is a checkbox to show or hide the password, and finally, a button to complete the registration.

<a>
        <img src="checkbox.png" alt="cheackbox" width="600" height="600"/>
  </a>

In the next window (after logging in), we can see the main application screen displaying a menu with three buttons: one to search for manga, another to register manga, and a third to close the program from there.

<a>
        <img src="menu.png" alt="menu" width="600" height="600"/>
  </a>

From the menu, we can register as many manga entries as we want. If all fields are filled in, a MessageDialog appears to inform the user that their manga has been successfully registered.

<a>
        <img src="mensaje.png" alt="MessageDialog" width="600" height="600"/>
  </a>

This is the "Search" screen, where we can see several textboxes to search by title, author, chapter, frequency, or genre. To perform the search, click the "Search" button. The results will appear in the ListView below. By clicking on the desired manga and pressing the "Open" button, we can view the complete manga details. There is also a button to go back.

<a>
        <img src="busqueda.png" alt="Search" width="600" height="600"/>
  </a>

This is the manga detail window. Here we can see an image of the manga, a summary, the title, chapter, author, release frequency, genre, and a link to view more information or even read the manga. From this screen, we can modify, delete, or return to the previous window.

<a>
        <img src="ficha.png" alt="detail window" width="600" height="600"/>
  </a>

To modify a manga, the edit window opens with the current manga data preloaded into the textboxes and checkboxes, as shown below. We then proceed to update the manga details and verify the changes in SQL Server.

<a>
        <img src="edit.png" alt="edit window" width="600" height="600"/>
  </a>

If we return to the selected manga, we can delete it from there.

<a>
        <img src="delete.png" alt="delete window" width="600" height="600"/>
  </a>

## Hardware

For the development of this project, the following hardware was used:

PC with Windows 10 operating system. Intel(R) Core(TM) i5-4590 CPU @ 3.30 GHz, 16.0 GB RAM (15.9 GB usable), 64-bit operating system, x64-based processor.

iMac with macOS High Sierra Version 10.13.6 (27-inch, Mid 2011). 2.7 GHz Intel Core i5 processor, 16 GB 1333 MHz DDR3 memory.

## Technologies

The following technologies were used for the development of this project:

Android Studio Bumblebee 2021.1.1 as the IDE for programming in this environment using the Java programming language.

Visual Studio 2022 as the IDE for programming in this environment using the C# programming language.

Windows Forms to create the graphical user interface.

Microsoft SQL Server v18.11.1, the DBMS used to host the database. Queries are performed using C#.
