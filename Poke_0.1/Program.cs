
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    public class Pokemon
    {
        public String Nombre
        {
            get => Nombre;
            set => Nombre = value;
        }

        public String Alias
        {
            get => Alias;
            set => Alias = value;
        }

        public float Peso
        {
            get => Peso;
            set => Peso = value;
        }

        public float Altura
        {
            get => Altura;
            set => Altura = value;
        }

        public List<String> Ataques;



        public String Tipo
        {
            get => Tipo;
            set => Tipo = value;
        }
    }

    public class PokemonFuego : Pokemon
    {


        public PokemonFuego()
        {
            Ataques.Add("PLACAJE ");
            Ataques.Add("GRUÑIDO");
            Ataques.Add("LANZALLAMAS");

        }
    }

    public class PokemonAgua : Pokemon
    {


        public PokemonAgua()
        {

            Ataques.Add("PLACAJE ");
            Ataques.Add("GRUÑIDO");
            Ataques.Add("CHORRO DE AGUA");
        }
    }

    public class PokemonPlanta : Pokemon
    {
        public PokemonPlanta()
        {

            Ataques.Add("PLACAJE ");
            Ataques.Add("GRUÑIDO");
            Ataques.Add("CHORRO DE AGUA");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int Opcion;
                Console.WriteLine("Desea ingresar un nuevo pokemon? Ingrese 0 para salir, 1 para continuar ingresando pokemones o 2 para listar todos los pokemones existentes");
                int.TryParse(Console.ReadLine(), out Opcion);

                List<Pokemon> Pokemones = new List<Pokemon>();

                switch (Opcion)
                {
                    // sale porque selecciono la opcion salir o una no válida
                    case 0:

                        break;
                    
                    // selecciona la opcion ingresar un pokemon
                    case 1:
                    
                        Console.WriteLine("Ingrese nombre del Pokemon");
                        String Nombre = Console.ReadLine();

                        Boolean Band = true;

                        // Busca en la lista si ya no existe el pokemon

                        foreach (Pokemon Poke in Pokemones)
                        {
                            if (Poke.Nombre == Nombre)
                            {
                                Band = false;
                                break;
                            }
                        }

                        // Si no existe: 
                        if (Band == true)
                        {

                            //Pide el tipo

                            int Tipo;
                            Console.WriteLine("Seleccione 1 si el pokemon es tipo FUEGO, 2 tipo PLANTA y 3 tipo AGUA");
                            int.TryParse(Console.ReadLine(), out Tipo);

                            float num;

                            switch (Tipo)
                            {
                                // Si ingresa un valor fuera del rango pedido o diferente a un int
                                case 0:

                                    break;

                                // Si el pokemon a ingresar es tipo FUEGO, creaun pkmn tipo Fuego
                                case 1:

                                    Pokemon poke = new PokemonFuego
                                    {
                                        Nombre = Nombre
                                    };

                                    Console.WriteLine("Ingrese Alias del Pokemon");
                                    poke.Alias = Console.ReadLine();

                                    Console.WriteLine("Ingrese el Peso del Pokemon");
                                    float.TryParse(Console.ReadLine(), out num);
                                    poke.Peso = num;

                                    Console.WriteLine("Ingrese Altura del Pokemon");
                                    float.TryParse(Console.ReadLine(), out num);
                                    poke.Altura = num;

                                    Pokemones.Add(poke);    // Lo agrega a al lista de pokemones


                                // Si el pokemon a ingresar es tipo PLANTA, creaun pkmn tipo PLANTA
                                case 2:

                                    Pokemon poke = new PokemonPlanta
                                    {
                                        Nombre = Nombre
                                    };

                                    Console.WriteLine("Ingrese Alias del Pokemon");
                                    poke.Alias = Console.ReadLine();

                                    Console.WriteLine("Ingrese el Peso del Pokemon");
                                    float.TryParse(Console.ReadLine(), out num);
                                    poke.Peso = num;

                                    Console.WriteLine("Ingrese Altura del Pokemon");
                                    float.TryParse(Console.ReadLine(), out num);
                                    poke.Altura = num;

                                    Pokemones.Add(poke);


                                // Si el pokemon a ingresar es tipo AGUA, creaun pkmn tipo AGUA
                                case 3:

                                    Pokemon poke = new PokemonAgua
                                    {
                                        Nombre = Nombre
                                    };

                                    Console.WriteLine("Ingrese Alias del Pokemon");
                                    poke.Alias = Console.ReadLine();

                                    Console.WriteLine("Ingrese el Peso del Pokemon");
                                    float.TryParse(Console.ReadLine(), out num);
                                    poke.Peso = num;

                                    Console.WriteLine("Ingrese Altura del Pokemon");
                                    float.TryParse(Console.ReadLine(), out num);
                                    poke.Altura = num;

                                    Pokemones.Add(poke);
                            }

                        }

                        // Si el pokemon ya se encuentra en la lista

                        else if (Band == false)
                        {
                            Console.WriteLine("Pokemon ya registrado");
                        }

                    // Se eligió la opción del listado

                    case 3:
                        foreach (Pokemon Pokemon in Pokemones)
                        {

                            Console.WriteLine("Nombre del Pokemon: ", Pokemon.Nombre);
                            Console.WriteLine("Alias del Pokemon: ", Pokemon.Alias);
                            Console.WriteLine("Peso del Pokemon: ", Pokemon.Peso);
                            Console.WriteLine("Altura del Pokemon: ", Pokemon.Altura);
                            Console.WriteLine("Sus ataques son: ", Pokemon.Ataques.ElementAt(0), ", ", Pokemon.Ataques.ElementAt(1), " y ", Pokemon.Ataques.ElementAt(3));
                        }

                }

            }

            Console.WriteLine("Gracias por usar nuestra Pokedex");
            Console.ReadLine();
        }
    }
}

