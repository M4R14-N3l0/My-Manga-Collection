using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMangaCollections
{
    class Manga
    {

        String id;
        String titulo;
        String capitulo;
        String autor;
        String periodicidad;
        String genero;
        String enlace;
        String resumen;


        public Manga() { }

        public Manga(String id, String titulo, String capitulo, String autor, String periodicidad, String genero, String enlace, String resumen)
        {
            this.id = id;
            this.titulo = titulo;
            this.capitulo = capitulo;
            this.autor = autor;
            this.periodicidad = periodicidad;
            this.genero = genero;
            this.enlace = enlace;
            this.resumen = resumen;

        }

        public String getId()
        {
            return id;
        }
        public void setId(String id)
        {
            this.id = id;
        }

        public String getTitulo()
        {
            return titulo;
        }
        public void setTitulo(String titulo)
        {
            this.titulo = titulo;
        }
        public String getCapitulo()
        {
            return capitulo;
        }
        public void setCapitulo(String capitulo)
        {
            this.capitulo = capitulo;
        }
        public String getAutor()
        {
            return autor;
        }
        public void setAutor(String autor)
        {
            this.autor = autor;
        }
        public String getPeriodicidad()
        {
            return periodicidad;
        }
        public void setPeriodicidad(String periodicidad)
        {
            this.periodicidad = periodicidad;
        }
        public String getGenero()
        {
            return genero;
        }
        public void setGenero(String genero)
        {
            this.genero = genero;
        }
        public String getEnlace()
        {
            return enlace;
        }
        public void setEnlace(String enlace)
        {
            this.enlace = enlace;
        }
        public String getResumen()
        {
            return resumen;
        }
        public void setResumen(String resumen)
        {
            this.resumen = resumen;
        }

    }
}
