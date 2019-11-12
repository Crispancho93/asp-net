using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud
{
    class Program
    {
        private static biowebEntities db = new biowebEntities();
        private static int sw;
        private static int menu;
        

        static void Main(string[] args)
        {
            do
            {
                // titúlo
                Console.WriteLine("***************CRUD***************");

                string[] names = { "cristian", "helena", "sarah", "julieta"};

                var consulta = from name in names
                               where name.Contains("z")
                               select name;
              

                foreach (var name in consulta)
                {
                    Console.WriteLine(name);
                }

                Console.Write("Continuar (1) o Finalizar(0): ");
                sw = Convert.ToInt32(Console.ReadLine());

            } while (sw == 1);

        }

        private static void menuPrograma(int menu)
        {
            // implementamos menú
            switch (menu)
            {
                case 1:

                    // creo entidad de usuario
                    UsuarioEntity user = new UsuarioEntity(); 

                    Console.Write("Nombre: ");
                    user.nombre = Console.ReadLine();

                    Console.Write("Tipo de usario: ");
                    user.tipoUsuario = Console.ReadLine();

                    Console.Write("Tipo documento: ");
                    user.tipoDocumento = Console.ReadLine();

                    Console.Write("Número documento: ");
                    user.numeroDocumento = Console.ReadLine();

                    Console.Write("Dirección: ");
                    user.direccion = Console.ReadLine();

                    Console.Write("Telefono: ");
                    user.telefono = Console.ReadLine();

                    Console.Write("Correo: ");
                    user.correo = Console.ReadLine();

                    Console.Write("Loguin: ");
                    user.loguin = Console.ReadLine();

                    Console.Write("Clave: ");
                    user.clave = Console.ReadLine();

                   // creamos el usuario
                    addUser(user);
                    break;
            }
        }

        public static bool addUser(UsuarioEntity user)
        {
            

            usuario userDB = new usuario()
            {

                nombre = user.nombre,
                tipo_usuario = user.tipoUsuario,
                tipo_documento = user.tipoDocumento,
                numero_documento = user.numeroDocumento,
                direccion = user.direccion,
                telefono = user.telefono,
                correo = user.correo,
                loguin = user.loguin,
                clave = user.clave
            };
            
 
            return true;
        }
    }
}
