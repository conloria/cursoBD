using System;
using System.Collections.Generic;

namespace Database
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conectando a la base de datos");
            Db database = new Db();
            database.Conectar();

            if (database.EstaLaConexionAbierta())
            {
                Usuario nuevoUsuario = new Usuario()
                {
                    //hiddenId = 0,
                    //id="",
                    firstName = "",
                    lastName = "",
                    email = "",
                    password ="",
                    photoUrl ="",
                    searchPreferences ="",
                    status = false,
                    deleted = false,
                    isAdmin = false,


                };


                //Usuario nuevoUsuario(nuevoUsuario);

                database.InsertarUsuario(nuevoUsuario);


                List<Usuario> listaUsuarios = database.DameLosUsuarios();

                listaUsuarios.ForEach(usuario => 
                {
                    Console.WriteLine(
                            "Nombre: " + usuario.firstName 
                            +
                            " Apellidos: " + usuario.lastName

                            +"Id: " + usuario.id
                            +"photoUrl: " + usuario.photoUrl
                            +"password: " + usuario.password
                       
                            );
                });
            }

            database.Desconectar();
            database = null;

            Console.ReadKey();
        }

        
    }
}
