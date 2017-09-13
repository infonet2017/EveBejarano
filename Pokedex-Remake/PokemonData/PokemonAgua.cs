using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonData
{
    public class PokemonAgua : Pokemon
    {
        public PokemonAgua(String Nombre, String alias, float altura, float peso)
        {
            Ataques.Add("PLACAJE ");
            Ataques.Add("GRUÑIDO");
            Ataques.Add("CHORRO DE AGUA");

            this.Nombre = Nombre;
            this.Alias = alias;
            this.Peso = peso;
            this.Altura = altura;
        }
    }
}
