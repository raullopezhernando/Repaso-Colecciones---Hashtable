using System;
using System.Collections;

namespace Repaso_Colecciones___Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {

            //Variables que vamos a necesitar
            int opcion = 0;
            string valor = "";
            bool encontrado = false;
            string llave = "";
            double precio = 0;

            //creamos nuestro Hashtable
            Hashtable tabla = new Hashtable();

            do
            {
                //Mostramos nuestro menú
                Console.WriteLine("1. Agregar elemento");
                Console.WriteLine("2. Quitar elemento");
                Console.WriteLine("3. Clear");
                Console.WriteLine("4. Encontrar Key");
                Console.WriteLine("5. Encontrar Value");
                Console.WriteLine("6. Salir");

                //Pedimos la opcion deseada
                Console.Write("Escoge una opción: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                if (opcion == 1)
                {
                    //pedimos el nombre del producto
                    Console.Write("Dame el nombre del producto: ");
                    valor = Console.ReadLine();
                    llave = Convert.ToString(valor);

                    //Pedimos el precio del producto
                    Console.Write("Dame el precio del producto: ");
                    valor = Console.ReadLine();
                    precio = Convert.ToDouble(valor);

                    //Agregamos el valor introducido por el usuario en el Hashtable
                    tabla.Add(llave, precio);
                }

                if (opcion == 2)
                {
                    //Pedimos el nombre del producto a eliminar
                    Console.Write("Dame el nombre del producto que quieres eliminar: ");
                    valor = Console.ReadLine();
                    llave = Convert.ToString(valor);

                    //Quitamos el elemento
                    tabla.Remove(llave);
                }

                if (opcion == 3)
                {
                    //Limpiamos nuestro Hashtable
                    tabla.Clear();
                }

                if (opcion == 4)
                {
                    //Pedimos el key que queremos encontrar
                    Console.Write("Dame el key que quieres encontrar: ");
                    valor = Console.ReadLine();
                    llave = Convert.ToString(valor);

                    //verificamos que se encuentre el key
                    encontrado = tabla.Contains(llave);

                    //Mostramos si se encontro
                    Console.WriteLine("Elemento encontrado = {0}", encontrado);
                }

                if (opcion == 5)
                {
                    //Pedimos el value que queremos encontrar
                    Console.Write("Dame el value que quieres encontrar: ");
                    valor = Console.ReadLine();
                    precio = Convert.ToDouble(valor);

                    //verificamos que se encuentre el Value
                    encontrado = tabla.ContainsValue(precio);

                    //Mostramos si se encontro
                    Console.WriteLine("Elemento encontrado = {0}", encontrado);
                }

                //Mostramos la información
                Console.WriteLine("El Hashtable tiene {0} parejas de key-value", tabla.Count);

                foreach (DictionaryEntry datos in tabla)
                    Console.WriteLine("[{0},{1}]\t", datos.Key, datos.Value);
                Console.WriteLine("");
                Console.WriteLine("....");


            } while (opcion != 6);

        }//Cierre de Main
    }
}
