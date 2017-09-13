using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonData
{
    public class PokeRepository
    {

        // Listas de los pokemons de cada tipo

        public List<PokemonPlanta> PokemonesPlanta { get; set; }
        public List<PokemonFuego> PokemonesFuego { get; set; }
        public List<PokemonAgua> PokemonesAgua { get; set; }


        //Lista general de todos los pokemons

        public List<Pokemon> Pokemones { get; set; }


        //Constructor de la clase Repositorio; inicializa todas las listas

        public PokeRepository()
        {
            PokemonesPlanta = new List<PokemonPlanta>();
            PokemonesFuego = new List<PokemonFuego>();
            PokemonesAgua = new List<PokemonAgua>();
            Pokemones = new List<Pokemon>();

        }


        //Metodos para guardar cada pokemon en la lista que le corresponde

        public void GuardarPokemonAgua(PokemonAgua pokemon)
        {
            PokemonesAgua.Add(pokemon);
        }

        public void GuardarPokemonFuego(PokemonFuego pokemon)
        {
            PokemonesFuego.Add(pokemon);
        }

        public void GuardarPokemonPlanta(PokemonPlanta pokemon)
        {
            PokemonesPlanta.Add(pokemon);
        }


        //Guarda los pokemons en la lista general

        public void GuardarPokemones(Pokemon pokemon)
        {
            Pokemones.Add(pokemon);
        }


        //Verifica que el pokemon no exista y lo Almacena en la lista general

        public void GuardarPokemon(Pokemon pokemon, int tipo)
        {
            switch (tipo)
            {
                case 1:
                    var Busqueda = PokemonesPlanta.Where(p => p.Nombre == pokemon.Nombre).ToList();

                    //if it didnt find any coincidence, then searchresult is null
                    if (Busqueda.Count() > 0)
                    {
                        throw new Exception("pokemon already stored");
                    }
                    else
                    {
                        //otherwise it stores the pokemon successfully
                        GuardarPokemones(pokemon);
                    }
                    break;

                case 2:
                    var Busqueda1 = PokemonesAgua.Where(p => p.Nombre == pokemon.Nombre).ToList();

                    //if it didnt find any coincidence, then searchresult is null
                    if (Busqueda1.Count() > 0)
                    {
                        throw new Exception("pokemon already stored");
                    }
                    else
                    {
                        //otherwise it stores the pokemon successfully
                        GuardarPokemones(pokemon);
                    }
                    break;

                //finds any coincidence in the list based on the pkm.Name

                case 3:
                    var Busqueda2 = PokemonesFuego.Where(p => p.Nombre == pokemon.Nombre).ToList();

                    //if it didnt find any coincidence, then searchresult is null
                    if (Busqueda2.Count() > 0)
                    {
                        throw new Exception("pokemon already stored");
                    }
                    else
                    {
                        //otherwise it stores the pokemon successfully
                        GuardarPokemones(pokemon);
                    }
                    break;
            }
        }


        //Devuelve la lista con todos los pokemones capturados

        public List<Pokemon> GetAll()
        {
            return Pokemones;
        }


        //Devuelve la lista con todos los pokemones capturados tipo planta

        public List<PokemonPlanta> GetAllPlanta()
        {
            return PokemonesPlanta;
        }


        //Devuelve la lista con todos los pokemones capturados tipo Fuego

        public List<PokemonFuego> GetAllFuego()
        {
            return PokemonesFuego;
        }


        //Devuelve la lista con todos los pokemones capturados tipo Agua

        public List<PokemonAgua> GetAllAgua()
        {
            return PokemonesAgua;
        }

       
    }
}
