using PokemonData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBusiness
{
    public class PokemonManager
    {
        private PokeRepository PokeRepository { get; set; }


        // Contructor de la clase, crea el repositorio de pokemones

        public PokemonManager()
        {
            PokeRepository = new PokeRepository();

        }


        // Devuelve la lista con todos los pokemons
        private PokeRepository GetPokemonRepository()
        {
            return PokeRepository;
        }
        


        // Registra un pokemon con los datos segun el tipo y 
        // lo Guardando en la lista correspondiente a dicho tipo.

        public void RegistrarPokemon(string nombre, string alias, int tipo, float altura, float peso)
        {
            switch (tipo)
            {
                case 1:
                    var pokemon = new PokemonFuego(nombre, alias, altura, peso);

                    try
                    {
                        PokeRepository.GuardarPokemon(pokemon, tipo);
                        PokeRepository.GuardarPokemonFuego(pokemon);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("something wrong with your data. Are you sure you are not storing the same pokemon twice?");
                    }

                    break;

                case 2:
                    var pokemon2 = new PokemonAgua(nombre, alias, altura, peso);

                    try
                    {
                        PokeRepository.GuardarPokemon(pokemon2, tipo);
                        PokeRepository.GuardarPokemonAgua(pokemon2);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("something wrong with your data. Are you sure you are not storing the same pokemon twice?");
                    }

                    break;

                case 3:
                    var pokemon3 = new PokemonPlanta(nombre, alias, altura, peso);

                    try
                    {
                        PokeRepository.GuardarPokemon(pokemon3, tipo);
                        PokeRepository.GuardarPokemonPlanta(pokemon3);
                    }
                    catch (Exception)
                    {

                        Console.WriteLine("something wrong with your data. Are you sure you are not storing the same pokemon twice?");
                    }

                    break;
            }

        }



        //Genera un texto con todos los datos de los pokemones capturados hasta el momento

        public string GetTodosPokemones()
        {
            var allPokemons = PokeRepository.GetAll();

            var text = "";

            foreach (var pkm in allPokemons)
            {

                text = $"{text}Nombre:{pkm.Nombre}; Alias:{pkm.Alias} Altura:{pkm.Altura}Peso: {pkm.Peso}\n";
            }

            return text;
        }


        //Devuelve el pokemon que coincida con el nombre ingresado

        public Pokemon BuscarNombre(string Nombre)
        {
            //lambda expression
            var Pokemones = PokeRepository.GetAll();
            var resultado = Pokemones.Find(p => p.Nombre == Nombre);

            //if it didnt find any coincidence, then searchresult is null
            if (resultado == null)
            {
                throw new Exception("pokemon already stored");
            }
            else
            {
                return (resultado);
            }
        }



        //Devuelve el pokemon que coincida con el alias ingresado

        public Pokemon BuscarAlias(string Alias)
        {
            //lambda expression
            var Pokemones = PokeRepository.GetAll();
            var resultado = Pokemones.Find(p => p.Alias == Alias);

            //if it didnt find any coincidence, then searchresult is null
            if (resultado == null)
            {
                throw new Exception("pokemon already stored");
            }
            else
            {
                return (resultado);
            }
        }



        //Devuelve la cantidad de pokemones capturados

        public int ContarPokemones()
        {
            //lambda expression
            var Pokemones = PokeRepository.GetAll();
            return Pokemones.Count();
        }



        //Devuelve la cantidad de pokemones capturados del tipo ingresado

        public int ContarPokemonesTipo(int tipo)
        {
            switch (tipo)
            {
                case 1:

                    var Listado = PokeRepository.GetAllFuego();
                    return Listado.Count();

                case 2:

                    var Listado2 = PokeRepository.GetAllAgua();
                    return Listado2.Count();


                case 3:
                    var Listado3 = PokeRepository.GetAllPlanta();
                    return Listado3.Count();

                default:
                    return 0;
            }
        }


        //Devuelve el promedio del peso de todos los pokemones

        public float PromedioPeso()
        {
            var Pokemones = PokeRepository.GetAll();
            float total = 0;
            foreach (var poke in Pokemones)
            {
                total = total + poke.Peso;
            }
            return (total / Pokemones.Count());
        }



        //Devuelve el promedio del Peso de todos los pokemones del tipo ingresado

        public float PromedioPesoPokemonesTipo(int tipo)
        {

            float total = 0;
            switch (tipo)
            {
                case 1:

                    var Pokes = PokeRepository.GetAllFuego();
                    foreach (var poke in Pokes)
                    {
                        total = total + poke.Peso;
                    }
                    return (total / Pokes.Count());

                case 2:

                    var Pokes1 = PokeRepository.GetAllAgua();
                    foreach (var poke in Pokes1)
                    {
                        total = total + poke.Peso;
                    }
                    return (total / Pokes1.Count());


                case 3:
                    var Pokes2 = PokeRepository.GetAllPlanta();

                    foreach (var poke in Pokes2)
                    {
                        total = total + poke.Peso;
                    }
                    return (total / Pokes2.Count());

                default:
                    return 0;
            }
        }



        //Devuelve el promedio de la altura de todos los pokemones

        public float PromedioAltura()
        {
            var Pokemones = PokeRepository.GetAll();
            float total = 0;
            foreach (var poke in Pokemones)
            {
                total = total + poke.Altura;
            }
            return (total / Pokemones.Count());
        }


        //Devuelve el promedio de la altura de todos los pokemones del tipo ingresado

        public float PromedioAlturaPokemonesTipo(int tipo)
        {

            float total = 0;
            switch (tipo)
            {
                case 1:

                    var Pokes = PokeRepository.GetAllFuego();
                    foreach (var poke in Pokes)
                    {
                        total = total + poke.Altura;
                    }
                    return (total / Pokes.Count());

                case 2:

                    var Pokes1 = PokeRepository.GetAllAgua();
                    foreach (var poke in Pokes1)
                    {
                        total = total + poke.Altura;
                    }
                    return (total / Pokes1.Count());


                case 3:
                    var Pokes2 = PokeRepository.GetAllPlanta();

                    foreach (var poke in Pokes2)
                    {
                        total = total + poke.Altura;
                    }
                    return (total / Pokes2.Count());

                default:
                    return 0;
            }
        }



    }
}
