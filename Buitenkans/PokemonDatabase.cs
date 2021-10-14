using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buitenkans
{
    public static class PokemonDatabase
    {
        public static List<Pokemon> PokemonLijst()
        {
            return new List<Pokemon>()
            {
                new ()
                {
                    Nummer = 1,
                    Naam = "Bulbaussaur",
                    Type = "Grass",
                    HP = "45",
                },
                new ()
                {
                    Nummer = 2,
                    Naam = "Ivysaur",
                    Type = "Grass",
                    HP = "60",
                },
                new ()
                {
                    Nummer = 3,
                    Naam = "Venusaur",
                    Type = "Grass",
                    HP = "80",
                },
                new ()
                {
                    Nummer = 4,
                    Naam = "Charmander",
                    Type = "Fire",
                    HP = "39",
                },
                new ()
                {
                    Nummer = 5,
                    Naam = "Charmeleon",
                    Type = "Fire",
                    HP = "58",
                },
                new ()
                {
                    Nummer = 6,
                    Naam = "Charizard",
                    Type = "Fire",
                    HP = "78",
                },
                new ()
                {
                    Nummer = 7,
                    Naam = "Squirtle",
                    Type = "Water",
                    HP = "44",
                },
                new ()
                {
                    Nummer = 8,
                    Naam = "Wartortle",
                    Type = "Water",
                    HP = "59",
                },
                new ()
                {
                    Nummer = 9,
                    Naam = "Blastoise",
                    Type = "Water",
                    HP = "79",
                },
                new ()
                {
                    Nummer = 10,
                    Naam = "Caterpie",
                    Type = "Bug",
                    HP = "45",
                },
                new ()
                {
                    Nummer = 11,
                    Naam = "Metapod",
                    Type = "Bug",
                    HP = "50",
                },
                new ()
                {
                    Nummer = 12,
                    Naam = "Butterfree",
                    Type = "Bug",
                    HP = "60",
                },
                new ()
                {
                    Nummer = 13,
                    Naam = "Weedle",
                    Type = "Bug",
                    HP = "40",
                },
                new ()
                {
                    Nummer = 14,
                    Naam = "Kakuna",
                    Type = "Bug",
                    HP = "45",
                },
                new ()
                {
                    Nummer = 15,
                    Naam = "Beedrill",
                    Type = "Bug",
                    HP = "65",
                },
                new ()
                {
                    Nummer = 25,
                    Naam = "Pikachu",
                    Type = "Electric",
                    HP = "35",
                },
                new ()
                {
                    Nummer = 147,
                    Naam = "Dratini",
                    Type = "Dragon",
                    HP = "41",
                },
                new ()
                {
                    Nummer = 148,
                    Naam = "Dragonair",
                    Type = "Dragon",
                    HP = "61",
                },
                new ()
                {
                    Nummer = 149,
                    Naam = "Dragonite",
                    Type = "Dragon",
                    HP = "91",
                },
                new ()
                {
                    Nummer = 150,
                    Naam = "Mewtwo",
                    Type = "Psychic",
                    HP = "106",
                },
                new ()
                {
                    Nummer = 151,
                    Naam = "Mew",
                    Type = "Psychic",
                    HP = "100",
                },
            };
        }
    }
}
