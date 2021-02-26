using System;
using System.Collections.Generic;
using System.Text;

namespace JSON_Pokemon_F
{
    public class allPokemonAPI
    {
        public List<ResultObject> results { get; set; }
        public List<PokemonSprites> sprites { get; set; }
    }
    public class ResultObject
    {
        public string name { get; set; }
        public string url { get; set; }
        public string resultObject { get; set; }
        public string height { get; set; }
        public string back_default { get; set; }
        public string front_default { get; set; }
        public string sprite { get; set; }
        public int weight { get; set; }
        public override string ToString()
        {
            return name.ToString();
        }
        
    }
    public class SelectedPokemon
    {
        public string name { get; set; }
        public string height {get; set;}
        public string weight {get; set;}
        public string sprite { get; set; }
        public string selectedPokemon { get; set; }
    }
    public class PokemonSprites
    {

        public string back_default { get; set; }
        public string front_default { get; set; }
        public string pokemonSprites { get; set; }
    }
    
    }

