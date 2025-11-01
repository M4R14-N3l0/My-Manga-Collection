using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MyMangaCollections
{
    class Conexion
    {


        public static Manga manga = new Manga();




        public static SqlConnection conectar()
        {
            SqlConnection cn = new SqlConnection("Data Source=MARIANELO; Initial catalog=colecciones;Integrated Security=True");
            cn.Open();
            return cn;
        }

        public String[]  BusquedaUsuarioyContrasena(String usuario, String contrasena)
        {
            contrasena = Encriptacion.GetSHA256(contrasena);
            SqlConnection cn = conectar();
            String consulta = "SELECT usuario, contrasena FROM usuarios where usuario=" + "'" + usuario + "'" + "and" + " " + "contrasena=" + "'" + contrasena + "'" + ";";
            SqlCommand sql_cmd = new SqlCommand(consulta, cn);
            SqlDataReader reader = sql_cmd.ExecuteReader();
            String[] consultas = new String[2];
            while (reader.Read()) {
            consultas[0]=reader["usuario"].ToString();
            consultas[1] =reader["contrasena"].ToString();
            }             
            return consultas;

        }


        
        public void Busqueda(Manga manga, ListView listView1)
        {



            SqlConnection cn = conectar();



           
            String titulo = manga.getTitulo();
            String capitulo = manga.getCapitulo();
            String autor = manga.getAutor();
            String periodicidad = manga.getPeriodicidad();
            String genero = manga.getGenero();
            String enlace= manga.getEnlace();   
            String resumen = manga.getResumen();
            String consulta = "SELECT titulo, capitulo, autor, periodicidad, genero, enlace, resumen FROM coleccion_uno where ";
            int hayalgo = 0;
            if (!titulo.Equals("")) {
                consulta += "titulo='"+titulo+"'";
                hayalgo = 1;
            }
            if (!capitulo.Equals(""))
            {
                if (hayalgo == 1)
                {
                    consulta += " and capitulo='"+capitulo+"'";
                }
                else { consulta += "capitulo='" + capitulo + "'"; }
                hayalgo = 1;
            }
            if (!autor.Equals(""))
            {
                if (hayalgo == 1)
                {
                    consulta += " and autor='" + autor + "'";
                }
                else { consulta += "autor='" + autor + "'"; }
                hayalgo = 1;
            }
            if (!periodicidad.Equals(""))
            {
                if (hayalgo == 1)
                {
                    consulta += " and periodicidad='" + periodicidad + "'";
                }
                else { consulta += "periodicidad='" + periodicidad + "'"; }
                hayalgo = 1;
            }
            if (!genero.Equals(""))
            {
                if (hayalgo == 1)
                {
                    consulta += " and genero='" + genero + "'";
                }
                else { consulta += "genero='" + genero + "'"; }
                hayalgo = 1;
            }
            if (!enlace.Equals(""))
            {
                if (hayalgo == 1)
                {
                    consulta += " and enlace='" + enlace + "'";
                }
                else { consulta += "enlace='" + enlace + "'"; }
                hayalgo = 1;
            }
            if (hayalgo == 1)
            {
                consulta += ";";
                Console.WriteLine(consulta);
                SqlCommand sql_cmd = new SqlCommand(consulta, cn);
                SqlDataReader reader = sql_cmd.ExecuteReader();

                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(reader["titulo"].ToString());
                    item.SubItems.Add(reader["capitulo"].ToString());
                    item.SubItems.Add(reader["autor"].ToString());
                    item.SubItems.Add(reader["periodicidad"].ToString());
                    item.SubItems.Add(reader["genero"].ToString());
                    item.SubItems.Add(reader["enlace"].ToString());
                    item.SubItems.Add(reader["resumen"].ToString());
                    listView1.Items.Add(item);
                }
               
            }
            else {
                MessageBox.Show("Tiene que introducir algún parámetro de búsqueda");
            }


            cn.Close();


        }
       

        public bool RegistroUsuario(String nombre, String contrasena)
         {

            String contrasena1 = Encriptacion.GetSHA256(contrasena);
            bool insertado = false;
             Conexion.conectar();
             String insertar = "INSERT INTO usuarios (usuario, contrasena) values (" + "'" + nombre + "'" + "," + "'" + contrasena1 + "'" + ");";


             SqlCommand sql_cmd = new SqlCommand(insertar, Conexion.conectar());
             


            try
             {
                 sql_cmd.ExecuteNonQuery();
                 insertado = true;
                 MessageBox.Show("Su usuario ha sido registrado");
             }
             catch (SqlException ex)
             {
                 Console.WriteLine(ex.Message);
             }
             return insertado;
         }

        public bool eliminarManga(String titulo, String capitulo)
        {

            bool eliminado = false;
            SqlConnection cn = conectar();
            try
            {
                String eliminar = "DELETE FROM coleccion_uno where titulo=@titulo and capitulo=@capitulo;";
                Console.WriteLine(eliminar);
                SqlCommand cmd = new SqlCommand(eliminar, Conexion.conectar());
                cmd.Parameters.AddWithValue("@titulo", titulo);
                cmd.Parameters.AddWithValue("@capitulo", capitulo);
                cmd.ExecuteNonQuery();
                eliminado = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return eliminado;
        }

        public bool modificarManga(String titulo, String capitulo, String autor, String periodicidad, String genero, String enlace, String resumen)
        {
            bool insertado = false;
            Conexion.conectar();


            String insertar = "UPDATE coleccion_uno SET titulo = '" + titulo + "', capitulo ='" + capitulo +
                "',autor='" + autor + "', periodicidad = '"
                + periodicidad + "', genero = '"
                + genero + "', enlace = '"
                 + enlace + "', resumen = '"
                + resumen + "'  where titulo=" + "'" + titulo + "'" + "and capitulo=" + "'" + capitulo + "'" + ";";


            SqlCommand sql_cmd = new SqlCommand(insertar, Conexion.conectar());
            try
            {
                sql_cmd.ExecuteNonQuery();
                insertado = true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return insertado;
        }

        public void RecargarImagen(PictureBox pb, String titulo, String capitulo)
        {

            SqlConnection cn = conectar();

            String consulta = "SELECT imagen FROM coleccion_uno where titulo=" + "'" + titulo + "'" + "and" + " " + "capitulo=" + "'" + capitulo + "'" + ";";
            SqlCommand sql_cmd = new SqlCommand(consulta, cn);
            SqlDataReader reader = sql_cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                MemoryStream ms = new MemoryStream((byte[])reader["imagen"]);
                Bitmap bm = new Bitmap(ms);
                pb.Image = bm;


            }
        }

       


        }


    }

     

