using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonData
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


        public Guid ID { get; set; }

        void GenerateID()
        {
            //Guid es un tipo de identificador unico al momento de crearlo
            ID = new Guid();
        }


    }
}
