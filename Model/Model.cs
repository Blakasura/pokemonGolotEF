using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using Microsoft.EntityFrameworkCore.Design;
using System.Text;

namespace Model
{
    public class Pokemon
    {
        [Key]
        public int id_pokemon { get; set; }

        // Attributes
        public string nom_pokemon { get; set; }
        public int stamina_pokemon { get; set; }
        public int atac_pokemon { get; set; }
        public int defensa_pokemon { get; set; }
        public int max_cp_pokemon { get; set; }
        public string rarity { get; set; }
        
        // Navigations
        public List<Moviment> moviments { get; set; }
        public virtual ICollection<Pokedex> vist_per_jugador { get; set;}
        public virtual ICollection<Pokemon_Tipus> te_tipus { get; set;}
        public virtual ICollection<Possible_Moviment> te_moviments { get; set;}
        public virtual ICollection<Evolucio> te_evolucio { get; set; }
        public virtual ICollection<Evolucio> es_evolucio { get; set; }
    }

    public class Evolucio
    {
        public int id_pokemon { get; set; }
        public int id_pokemon_evolucio { get; set; }
        public int caramels_necessaris { get; set; }
        
        public virtual Pokemon pokemon { get; set; }
        public virtual Pokemon evolucio { get; set; }
    }

    public class Moviment
    {
        [Key]
        public int id_moviment { get; set; }

        // Attributes
        public int duracio_moviment { get; set; }
        public int delta_energia_pokemon_moviment { get; set; }
        public string nom_moviment { get; set; }
        public int potencia_moviment { get; set; }
        public double escalat_perduda_moviment { get; set; }
        public int tipus_id { get; set; }

        // Navigations
        public Tipus tipus { get; set; }
        public List<Pokemon> pokemons { get; set; }
        public virtual ICollection<Pokemon_Moviment> son_de_pokemon { get; set;}
        public virtual ICollection<Possible_Moviment> poden_ser_de_pokemon { get; set; }
    }

    public class Tipus
    {
        [Key]
        public int id_tipus { get; set; }

        // Attributes
        public string nom_tipus { get; set; }

        // Navigations
        public virtual ICollection<Moviment> te_moviments { get; set; }
        public virtual ICollection<Efectivitat> fa_efectivitat { get; set;}
        public virtual ICollection<Efectivitat> te_efectivitat { get; set;}
        public virtual ICollection<Pokemon_Tipus> te_pokemon { get; set;}

    }

    public class Jugador
    {
        [Key]
        public string nom_jugador { get; set; }

        // Attributes
        public string email_jugador { get; set; }
        public string contrasenya_jugador { get; set; }
        public double nivell_jugador { get; set; }
        public int maxim_objectes_jugador { get; set; }  
        public int maxim_pokemons_jugador { get; set; }

        // Navigations
        public Equip? equip { get; set; }
        public List<Gimnas>? gimnasos { get; set; }
        public virtual ICollection<Amistat>? fa_amistats { get; set;}
        public virtual ICollection<Amistat>? te_amistats { get; set;}
        public virtual ICollection<Missio_Jugador>? te_missio { get; set;}
        public virtual ICollection<Objecte_Jugador>? te_objectes { get; set;}
        public virtual ICollection<Pokedex>? registrat_pokemon { get; set;}
        public virtual ICollection<Regal>? te_regal { get; set;}
        public virtual ICollection<Enviat>? rep_regal { get; set;}
        public virtual ICollection<Ou_Jugador>? te_ou { get; set;}
    }

    public class Equip
    {
        [Key]
        public string nom_equip { get; set; }

    }

    public class Objecte
    {
        [Key]
        public string nom_objecte { get; set; }

        // Attributes
        public string descripcio_objecte { get; set; }
        public double preu_objecte { get; set; }

        // Navigations
        public virtual ICollection<Objecte_Jugador> pertany_a_jugador { get; set;}
    }

    public class Ou
    {
        [Key]
        public string tipus_ou { get; set; }

        // Attributes
        public string descripcio_ou { get; set; }
        public double distancia_ou { get; set; }

        // Navigations
        public virtual ICollection<Ou_Jugador> pertany_a_jugador { get; set;}
    }

    public class Pokeparada
    {
        [Key]
        public int id_pokeparada { get; set; }

        // Attributes
        public string ubicacio_pokeparada { get; set; }

        // Navigations
        public virtual ICollection<Regal> dona_regal { get; set;}
    }

    public class Gimnas
    {
        [Key]
        public int id_gimnas { get; set; }

        // Attributes
        public string ubicacio_gimnas { get; set; }
        public int exp_gimnas { get; set; }

        // Navigations
        public Equip equip { get; set; }
        public List<Jugador> jugadors { get; set; }
        public virtual ICollection<Jugador_Pokemon_Gimnas> te_pokemons { get; set;}

    }

    public class Incursio
    {
        [Key]
        public int id_incursio { get; set; }
        
        // Attributes
        public string ubicacio_incursio { get; set; }

        // Navigations
        public Pokemon pokemon { get; set; }
        public Gimnas gimnas { get; set; }
    }

    public class Regal
    {
        // PK - FK
        public int id_pokeparada { get; set; }
        public string id_jugador { get; set; }

        // Navigations
        public Pokeparada pokeparada { get; set; }
        public Jugador jugador { get; set; }
        public virtual ICollection<Enviat> estan_enviats { get; set;}
    }

    public class Enviat 
    {  
        // PK - FK
        public int id_regal_pokeparada { get; set;}
        public string id_regal_jugador { get; set;}
        public string id_jugador_enviat { get; set;}

        // Attributes
        public bool obert { get; set; }
        
        // Navigations
        public Regal regal { get; set;}
        public Jugador jugador_enviat { get; set;}
    }

    public class Missio
    {
        [Key]
        public int id_misio { get; set; }

        // Attributes
        public string descripcio_misio { get; set; }
        public int objectiu_misio { get; set; }
        public int recompensa_misio { get; set; }
        public bool tipus_misio { get; set; }

        // Navigations
        public virtual ICollection<Missio_Jugador> te_jugadors { get; set;}
    }

    public class Objecte_Jugador
    {
        // PK - FK 
        public string jugadorId { get; set;}
        public string objecteId { get; set;}
       
        // Attributes
        public int quantitat { get; set; }

        // Navigations
        public Jugador jugador { get; set; }
        public Objecte objecte { get; set; }
    }

    public class Jugador_Pokemon
    {
        [Key]
        public int id_jugador_pokemon { get; set; }

        // Attributes
        public int punts_combat_jugador_pokemon { get; set; }
        public int IV_atac_jugador_pokemon { get; set; }
        public int IV_defensa_jugador_pokemon { get; set; }
        public int IV_vida_jugador_pokemon { get; set; }
        public int nivell_jugador_pokemon { get; set; }
        public int vida_pokemon { get; set; }
        public string ubicacio_pokemon { get; set; }

        // FK
        public string jugadorId { get; set;}

        // Navigations
        public Jugador jugador { get; set; }
        public Pokemon pokemon { get; set; }
        public virtual ICollection<Jugador_Pokemon_Gimnas> esta_a_gimnas { get; set;}
        public virtual ICollection<Pokemon_Moviment> te_moviments { get; set;}

    }
    public class Ou_Jugador
    {
        // PK - FK
        public string jugador_id { get; set;}
        public string ou_id { get; set;}

        // Attributes
        public double distancia { get; set; }

        // Navigations
        public Jugador jugador { get; set; }
        public Ou ou { get; set; }
        
    }
    public class Jugador_Pokemon_Gimnas
    {
        // PK - FK
        public int jugador_pokemonId { get; set;}
        public int gimnasId { get; set;}

        // Navigations
        public Jugador_Pokemon jugador_pokemon { get; set; }
        public Gimnas gimnas { get; set; }
    }

    public class Amistat
    {
        // PK - FK
        public string JugadorId { get; set;}
        public string JugadorId2 { get; set;}

        // Attributes
        public int nivell_amistat { get; set; }
        public bool intercanvi_amistat { get; set; }
        public bool activat_amistat { get; set; }
    
        // Navigations
        public virtual Jugador jugador1 { get; set; }
        public virtual Jugador jugador2 { get; set; }
    }

    public class Efectivitat
    {
        // PK - FK
        public int tipusId { get; set; }
        public int tipusId2 { get; set; }

        // Attributes
        public double efectivitat { get; set; }
        
        // Navigations
        public Tipus tipus1 { get; set; }
        public Tipus tipus2 { get; set; }
    }

    public class Pokedex
    {
        // PK - FK
        public int pokemonId { get; set; }
        public string jugadorId { get; set;}

        // Attributes
        public bool vist_pokedex { get; set; }
        public int caramels_pokedex { get; set; }

        // Navigations
        public Pokemon pokemon { get; set; }
        public Jugador jugador { get; set; }
        
    }


    public class Missio_Jugador
    {
        // PK - FK
        public string jugadorId { get; set;}
        public int missioId { get; set;}
         
        // Attributes
        public int progres_missio { get; set; }
        public bool activa_missio { get; set; }

        // Navigations
        public Jugador jugadorM { get; set; }
        public Missio missio { get; set; }
    }

    public class Pokemon_Moviment
    { 
        // PK - FK
        public int id_jugador_pokemon { get; set;}
        public int id_moviment { get; set; }

        // Navigations
        public Jugador_Pokemon jugador_pokemon { get; set;}
        public Moviment moviment { get; set;}

    }

    public class Pokemon_Tipus { 
    
        // PK - FK
        public int pokemon_id { get; set;}
        public int tipus_id { get; set;}

        // Navigations
        public Pokemon pokemon { get; set;}
        public Tipus tipus { get; set;}
    }

    public class Possible_Moviment { 
    
        // PK - FK
        public int pokemon_id { get; set; }
        public int moviment_id { get; set; }
    
        // Navigators
        public Pokemon pokemon { get; set; }
        public Moviment moviment { get; set; }
    }
}