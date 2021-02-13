using System;

namespace TpBlasutig
{
    class Program
    {
        

        public struct ItemsDetalles
        {
            public int Id;
            public string Marca;
            public string Descripcion;
            public double Precio;

        }

        public static ItemsDetalles[] CargarItem()
        {
            int n;
            ItemsDetalles item = new ItemsDetalles();
            ItemsDetalles[] ItemArray = new ItemsDetalles[100];
            string dato;

            for (n = 0; n < 100; n++)
            {
                Console.WriteLine("ingresar ID: ");
                dato = Console.ReadLine();
                item.Id = Convert.ToInt32(dato);

                Console.WriteLine("ingresar Marca: ");
                item.Marca = Console.ReadLine();
                

                Console.WriteLine("ingresar Descripción: ");
                item.Descripcion = Console.ReadLine();
                

                Console.WriteLine("ingresar Precio: ");
                dato = Console.ReadLine();
                item.Precio = Convert.ToDouble(dato);

                ItemArray[n] = item;
          
            }
            return(ItemArray);


        }

        public static void RealizarVenta(ItemsDetalles[] ItemArray)
        {
            string dato;
            int Id;
            double sumatoria = 0;

            do
            {
                // ingrese producto
                Console.WriteLine("ingresar ID: ");
                dato = Console.ReadLine();
                Id = Convert.ToInt32(dato);

                if (Id != 0)
                {
                    int posicion = 0;
                    double precio;
                    int cantidad = 0;

                    for (int i = 0; i < 100 ; i++)
                    {
                        if (ItemArray[i].Id == Id)
                        {
                            posicion = i;
                            break;

                        }
                    
                    }
                    precio = ItemArray[posicion].Precio;

                    Console.WriteLine("ingresar cantidad: ");
                    dato = Console.ReadLine();
                    cantidad = Convert.ToInt32(dato);
                    sumatoria = sumatoria + (precio*cantidad);
                    
                }
                             
            } while (Id != 0);

            Console.WriteLine("El total a pagar es: ${0}",sumatoria);
            Console.WriteLine("\n");
        }
           

        static void Main(string[] args)
        
        {
         

        
            ItemsDetalles[] Item = new ItemsDetalles[100];
            int opcion =3;

            do
            {
                Console.WriteLine("MENU DE OPCIONES.");
                Console.WriteLine("\n"+
                "\n Opción 1: Cargar Item."+
                "\n Opción 2: Realizar venta."+
                "\n Opcion 0: Finalizar Programa.");

                Console.WriteLine("Elegir una opcion para proseguir : ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Item = CargarItem();

                        break;
                    case 2:
                        RealizarVenta(Item);
                    
                        break;
                    case 0:
                        Console.WriteLine("Saliendo de la aplicación.");
                        break;
                    default:
                        Console.WriteLine("Ingresar una opción valida.");
                        break;
                }


            } while(opcion != 0);


           
        }
        
    }
}
    
