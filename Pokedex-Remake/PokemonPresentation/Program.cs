using PokemonBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonPresentation
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean bandera = true;
            PokemonManager PokeManager = new PokemonManager();

            while (bandera)
            {

                Console.WriteLine("Desea ingresar un nuevo pokemon? Ingrese 0 para salir, 1 para continuar ingresando pokemones o 2 para listar todos los pokemones existentes");


                int.TryParse(Console.ReadLine(), out int option);
           

                switch (option)
                {
                    case 0:
                        bandera = false;
                        break;


                    // selecciona la opcion ingresar un pokemon
                    case 1:

                        Console.WriteLine("Ingrese nombre del Pokemon");
                        String Nombre = Console.ReadLine();


                        //Pide el tipo

                        int Tipo;
                        Console.WriteLine("Seleccione 1 si el pokemon es tipo FUEGO, 2 tipo AGUA y 3 tipo PLANTA");
                        int.TryParse(Console.ReadLine(), out Tipo);

                        float num;

                        if (Tipo == 1 | Tipo == 2 || Tipo == 3)
                        {

                            //Pide los datos del pokemon

                            Console.WriteLine("Ingrese Alias del Pokemon");
                            var Alias = Console.ReadLine();

                            Console.WriteLine("Ingrese el Peso del Pokemon");
                            float.TryParse(Console.ReadLine(), out num);
                            var Peso = num;

                            Console.WriteLine("Ingrese Altura del Pokemon");
                            float.TryParse(Console.ReadLine(), out num);
                            var Altura = num;

                            // Lo agrega a la lista de pokemones del tipo ingresado y a la lista general

                            PokeManager.RegistrarPokemon(Nombre, Alias, Tipo, Altura, Peso);    

                        }
                        else
                        {
                            // Si el tipo ingresado no es válido

                            Console.WriteLine("Tipo ingresado no válido ");

                        }

                        break;

                    case 2:
                        // Selecciono la opcion listar, entonces llama a la funcion listar que genera un texto 

                        var text = PokeManager.GetTodosPokemones();
                        Console.WriteLine(text);
                        break;

                    default:

                        // Cuando no ingreso una opción válida ni un caracter inválido

                        Console.WriteLine("Opción NO válidad, vuelva a intentar");
                        break;
                }

            }

            Console.WriteLine("Gracias por usar nuestra Pokedex");
            Console.ReadLine();
        }
    }

}
