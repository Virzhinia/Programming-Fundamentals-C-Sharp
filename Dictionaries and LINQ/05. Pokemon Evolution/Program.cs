using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";

            Dictionary<string, List <KeyValuePair<string,long>>> PokemonDic = 
                new Dictionary<string, List<KeyValuePair<string, long>>>();

            List<string> PokemonList = new List<string>();

            while (true)
            {
                input = Console.ReadLine();

                if (input == "wubbalubbadubdub")
                {
                    break;
                }

                string[] inputArr = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (inputArr.Length == 1)
                {
                    PokemonList.Add(inputArr[0]);
                }

                else
                {
                    string pokemonName = inputArr[0];
                    string pokemonType = inputArr[1];
                    long evolutionIndex = long.Parse(inputArr[2]);

                    if (!PokemonDic.ContainsKey(pokemonName))
                    {
                        PokemonDic.Add(pokemonName, new List<KeyValuePair<string, long>>());
                    }

                        PokemonDic[pokemonName].Add(new KeyValuePair<string, long>( pokemonType, evolutionIndex));
                }

            }

            if (PokemonList.Count > 0)
            {
                foreach (var pokemon in PokemonList)
                {
                    if (PokemonDic.ContainsKey(pokemon))
                    {
                        Console.WriteLine($"# {pokemon}");

                        foreach (var type in PokemonDic[pokemon])
                        {
                            Console.WriteLine($"{type.Key} <-> {type.Value}");
                        }
                    }
                }

                foreach (var pokemon in PokemonDic)
                {
                    Console.WriteLine($"# {pokemon.Key}");

                    foreach (var type in pokemon.Value.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"{type.Key} <-> {type.Value}");
                    }
                }
            }

            else
            {
                foreach (var pokemon in PokemonDic)
                {
                    Console.WriteLine($"# {pokemon.Key}");

                    foreach (var type in pokemon.Value.OrderByDescending(x => x.Value))
                    {
                        Console.WriteLine($"{type.Key} <-> {type.Value}");
                    }
                }
            }
        }
    }
}
