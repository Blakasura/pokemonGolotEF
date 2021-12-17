using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ApiModel;

using Microsoft.EntityFrameworkCore.Design;
using Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using pokemonGolot.Model;

namespace Data
{
    static class data_loading
    {
        /*public static async Task load_dataAsync()
        {

            // POKEMONS ////////////////////////////////////////////
            HttpClient pogoApi = new HttpClient();
            HttpClient pokeApi = new HttpClient();
            pogoApi.BaseAddress = new Uri("https://pogoapi.net/api/v1/");
            pokeApi.BaseAddress = new Uri("https://pokeapi.co/api/v2/");

            // Add an Accept header for JSON format.
            pogoApi.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            List<Pokemon> pokemons;
            List<Moviment> moviments;
            List<Tipus> tipus;
            List<Possible_Moviment> possibles_moviments;
            List<Pokemon_Tipus> pokemons_tipus;

            pokemons = await getPokemons(pogoApi);
            tipus = await getTypes(pokeApi);
            moviments = await getMoves(pogoApi, tipus);
            possibles_moviments = await getPokemonMoves(pogoApi, pokemons, moviments);
            pokemons_tipus = await getPokemonTypes(pogoApi, pokemons, tipus);

            using (var context = new Database())
            {
                context.AddRange(pokemons);
                context.AddRange(moviments);
                context.AddRange(tipus);
                await context.SaveChangesAsync();
                context.AddRange(possibles_moviments);
                context.AddRange(pokemons_tipus);
                await context.SaveChangesAsync();
            }

        }*/
        
        public static async Task<List<Pokemon>> getPokemons(HttpClient apiClient) {
            List<Pokemon> pokemons = new List<Pokemon>();
            List<pokemon_max_cp> pokemon_max_cp = new List<pokemon_max_cp>();
            List<pokemon_stats> pokemon_stats = new List<pokemon_stats>();
            pokemon_rarity pokemon_rarity = new pokemon_rarity();


            // List data response.
            HttpResponseMessage response = apiClient.GetAsync("pokemon_max_cp.json").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                string dataObjects = await response.Content.ReadAsStringAsync();  //Make sure to add a reference to System.Net.Http.Formatting.dll
                pokemon_max_cp = JsonConvert.DeserializeObject<List<pokemon_max_cp>>(dataObjects);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            // List data response.
            HttpResponseMessage response2 = apiClient.GetAsync("pokemon_stats.json").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                string dataObjects = await response2.Content.ReadAsStringAsync();  //Make sure to add a reference to System.Net.Http.Formatting.dll
                pokemon_stats = JsonConvert.DeserializeObject<List<pokemon_stats>>(dataObjects);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            // List data response.
            HttpResponseMessage response3 = apiClient.GetAsync("pokemon_rarity.json").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                string dataObjects = await response3.Content.ReadAsStringAsync();  //Make sure to add a reference to System.Net.Http.Formatting.dll
                pokemon_rarity = JsonConvert.DeserializeObject<pokemon_rarity>(dataObjects);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            if (pokemon_max_cp != null && pokemon_stats != null && pokemon_rarity != null) {
                String lastPokemon = "";
                Pokemon pokemonAAfegir;
                Legendary legendary = new Legendary();
                Mythic mythic = new Mythic();
                Standard standard = new Standard();

                int ind = 0;
                foreach (pokemon_max_cp pokemon in pokemon_max_cp)
                {
                    pokemonAAfegir = new Pokemon();
                    pokemonAAfegir.id_pokemon = pokemon.pokemon_id;
                    pokemonAAfegir.nom_pokemon = pokemon.pokemon_name;
                    pokemonAAfegir.stamina_pokemon = pokemon_stats[ind].base_stamina;
                    pokemonAAfegir.atac_pokemon = pokemon_stats[ind].base_attack;
                    pokemonAAfegir.defensa_pokemon = pokemon_stats[ind].base_defense;
                    pokemonAAfegir.max_cp_pokemon = pokemon.max_cp;

                    if (pokemon_rarity.Legendary.Any(legendary => legendary.pokemon_name == pokemonAAfegir.nom_pokemon))
                    {
                        pokemonAAfegir.rarity = "Legendary";
                    }
                    else
                    {
                        mythic.form = "Normal";
                        mythic.pokemon_id = pokemonAAfegir.id_pokemon;
                        mythic.pokemon_name = pokemonAAfegir.nom_pokemon;
                        mythic.rarity = "Mythic";

                        if (pokemon_rarity.Mythic.Any(mythic => mythic.pokemon_name == pokemonAAfegir.nom_pokemon))
                        {
                            pokemonAAfegir.rarity = "Mythic";
                        }
                        else
                        {
                            pokemonAAfegir.rarity = "Standard";
                        }
                    }

                    if (lastPokemon != pokemonAAfegir.nom_pokemon)
                    {
                        pokemons.Add(pokemonAAfegir);
                        Console.WriteLine("Pokemon: " + pokemonAAfegir.nom_pokemon + ", Id: " + pokemonAAfegir.id_pokemon + ", Atac: " + pokemonAAfegir.atac_pokemon + ", Raresa: " + pokemonAAfegir.rarity);
                    }
                    else
                    {
                        ///// Pokemon repetit
                    }

                    lastPokemon = pokemonAAfegir.nom_pokemon;
                    ind++;
                }
            }

            return pokemons;
        }

        public static async Task<List<Tipus>> getTypes(HttpClient apiClient)
        {
            List<Tipus> tipus = new List<Tipus>();
            types types = new types();
            Tipus tipusAAfegir;
            int ind = 1;

            // List data response.
            HttpResponseMessage response = apiClient.GetAsync("type").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                string dataObjects = await response.Content.ReadAsStringAsync();  //Make sure to add a reference to System.Net.Http.Formatting.dll
                types = JsonConvert.DeserializeObject<types>(dataObjects);

                foreach (Result result in types.results)
                {
                    tipusAAfegir = new Tipus();
                    tipusAAfegir.id_tipus = ind;
                    tipusAAfegir.nom_tipus = result.name;
                    Console.WriteLine("Tipus id: " + tipusAAfegir.id_tipus + ", Nom tipus: " + tipusAAfegir.nom_tipus);
                    tipus.Add(tipusAAfegir);
                    ind++;
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            return tipus;
        }

        public static async Task<List<Moviment>> getMoves(HttpClient apiClient, List<Tipus> tipus)
        {
            List<Moviment> moviments = new List<Moviment>();
            Moviment moviment;
            List<fast_moves> fast_moves = new List<fast_moves>();
            List<charged_moves> charged_moves = new List<charged_moves>();

            // List data response.
            HttpResponseMessage response = apiClient.GetAsync("fast_moves.json").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                string dataObjects = await response.Content.ReadAsStringAsync();  //Make sure to add a reference to System.Net.Http.Formatting.dll
                fast_moves = JsonConvert.DeserializeObject<List<fast_moves>>(dataObjects);

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            // List data response.
            HttpResponseMessage response2 = apiClient.GetAsync("charged_moves.json").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                string dataObjects = await response2.Content.ReadAsStringAsync();  //Make sure to add a reference to System.Net.Http.Formatting.dll
                charged_moves = JsonConvert.DeserializeObject<List<charged_moves>>(dataObjects);
                
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            int ind = 1;

            foreach (fast_moves move in fast_moves) {
                moviment = new Moviment();
                moviment.id_moviment = ind;
                moviment.nom_moviment = move.name;
                moviment.potencia_moviment = move.power;
                moviment.duracio_moviment = move.duration;
                moviment.delta_energia_pokemon_moviment = move.energy_delta;
                moviment.tipus_id = tipus.Find(t => t.nom_tipus == move.type.ToLower()).id_tipus;
                moviments.Add(moviment);
                Console.WriteLine("Moviment id: " + moviment.id_moviment + ", Nom moviment: " + moviment.nom_moviment + ", Tipus: " + moviment.tipus_id);
                ind++;
            }

            // For loading charged_moves
            /*foreach (charged_moves move in charged_moves)
            {
                moviment = new Moviment();
                moviment.id_moviment = ind;
                moviment.nom_moviment = move.name;
                moviment.potencia_moviment = move.power;
                moviment.duracio_moviment = move.duration;
                moviment.delta_energia_pokemon_moviment = move.energy_delta;
                moviment.tipus = tipus.Find(t => t.nom_tipus == move.type.ToLower());
                moviments.Add(moviment);
                Console.WriteLine("Moviment id: " + moviment.id_moviment + ", Nom moviment: " + moviment.nom_moviment + ", Tipus: " + moviment.tipus.nom_tipus);
                ind++;
            }*/
            return moviments;
        }

        public static async Task<List<Possible_Moviment>> getPokemonMoves(HttpClient apiClient, List<Pokemon> pokemons, List<Moviment> moviments)
        {
            List<current_pokemon_moves> current_pokemon_moves = new List<current_pokemon_moves>();
            List<Possible_Moviment> possibles_moviments = new List<Possible_Moviment>();
            Possible_Moviment PmAAfegir;
            int lastInd = 10000;
            // List data response.
            HttpResponseMessage response = apiClient.GetAsync("current_pokemon_moves.json").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode) 
            {
                // Parse the response body.
                string dataObjects = await response.Content.ReadAsStringAsync();  //Make sure to add a reference to System.Net.Http.Formatting.dll
                current_pokemon_moves = JsonConvert.DeserializeObject<List<current_pokemon_moves>>(dataObjects);

            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            foreach (current_pokemon_moves current in current_pokemon_moves)
            {
                if (lastInd != current.pokemon_id)
                {
                    foreach (String moviment in current.fast_moves)
                    {
                        PmAAfegir = new Possible_Moviment();
                        PmAAfegir.moviment_id = moviments.Find(m => m.nom_moviment == moviment).id_moviment;
                        PmAAfegir.pokemon_id = current.pokemon_id;
                        possibles_moviments.Add(PmAAfegir);
                        Console.WriteLine("Pokemon: " + PmAAfegir.pokemon_id + ", Moviment: " + PmAAfegir.moviment_id);
                        lastInd = PmAAfegir.pokemon_id;
                    }

                }

                // For loading charged moves
                /*foreach (String moviment in current.charged_moves)
                {
                    PmAAfegir = new Possible_Moviment();
                    PmAAfegir.moviment_id = moviments.Find(m => m.nom_moviment == moviment.ToLower()).id_moviment;
                    PmAAfegir.pokemon_id = current.pokemon_id;
                    possibles_moviments.Add(PmAAfegir);
                    Console.WriteLine(PmAAfegir.moviment_id + " " + PmAAfegir.pokemon_id);
                }*/

            }

            return possibles_moviments;
        }

        public static async Task<List<Pokemon_Tipus>> getPokemonTypes(HttpClient apiClient, List<Pokemon> pokemons, List<Tipus> tipus)
        {
            List<Pokemon_Tipus> pokemons_tipus = new List<Pokemon_Tipus>();
            List<pokemon_types> pokemon_types = new List<pokemon_types>();
            Pokemon_Tipus PtAAfegir;
            int lastInd = 10000;
            // List data response.
            HttpResponseMessage response = apiClient.GetAsync("pokemon_types.json").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                string dataObjects = await response.Content.ReadAsStringAsync();  //Make sure to add a reference to System.Net.Http.Formatting.dll
                pokemon_types = JsonConvert.DeserializeObject<List<pokemon_types>>(dataObjects);
                
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            foreach (pokemon_types pokemon_type in pokemon_types)
            {
                if (lastInd != pokemon_type.pokemon_id) {
                    foreach (String tp in pokemon_type.type)
                    {
                        PtAAfegir = new Pokemon_Tipus();
                        PtAAfegir.pokemon_id = pokemon_type.pokemon_id;
                        PtAAfegir.tipus_id = tipus.Find(t => t.nom_tipus.ToLower() == tp.ToLower()).id_tipus;
                        pokemons_tipus.Add(PtAAfegir);

                        Console.WriteLine("Pokemon id: " + PtAAfegir.pokemon_id + ", Tipus id: " + PtAAfegir.tipus_id);
                    }
                    lastInd = pokemon_type.pokemon_id;
                }
                
            }
            return pokemons_tipus;
        }

        public static async Task<List<Evolucio>> getPokemonEvolutions(HttpClient apiClient, List<Pokemon> pokemons)
        {
            List<Evolucio> evolucions = new List<Evolucio>();
            List<pokemon_evolucions> evolutions = new List<pokemon_evolucions>();
            Evolucio evolucioAAfegir;
            int lastPok = 10000;
            int lastEvo = 10000;

            // List data response.
            HttpResponseMessage response = apiClient.GetAsync("pokemon_evolutions.json").Result;  // Blocking call! Program will wait here until a response is received or a timeout occurs.
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body.
                string dataObjects = await response.Content.ReadAsStringAsync();  //Make sure to add a reference to System.Net.Http.Formatting.dll
                evolutions = JsonConvert.DeserializeObject<List<pokemon_evolucions>>(dataObjects);
            }
            else
            { 
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }

            
            foreach (pokemon_evolucions pokemon_evolucio in evolutions)
            {
                foreach (Evolution evo in pokemon_evolucio.evolutions)
                {
                    if (lastPok != pokemon_evolucio.pokemon_id && lastEvo != evo.pokemon_id)
                    {
                        evolucioAAfegir = new Evolucio();
                        evolucioAAfegir.id_pokemon = pokemons.Find(p => p.id_pokemon == pokemon_evolucio.pokemon_id).id_pokemon;
                        evolucioAAfegir.id_pokemon_evolucio = pokemons.Find(p => p.id_pokemon == evo.pokemon_id).id_pokemon;
                        evolucioAAfegir.caramels_necessaris = evo.candy_required;
                        evolucions.Add(evolucioAAfegir);
                        Console.WriteLine("Pokemon id: " + evolucioAAfegir.id_pokemon + ", Evolucio id: " + evolucioAAfegir.id_pokemon_evolucio);
                        lastEvo = evo.pokemon_id;
                    }
                    lastPok = pokemon_evolucio.pokemon_id; 
                }
            }

            return evolucions;
        }

    }
}
