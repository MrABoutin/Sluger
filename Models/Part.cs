using System;
using System.Collections.Generic;
using System.IO;

namespace Sluger.Models
{
    public struct Part
    {
        public static string[] First =
        {
            "Buzzing", 
            "Essential", 
            "Screaming", 
            "Chasing", 
            "Creeping", 
            "Dancing", 
            "Hidden", 
            "Wealthy", 
            "Peaceful", 
            "Submissive", 
            "Great", 
            "Blurry", 
            "Gallant", 
            "Lazy", 
            "Sneering", 
            "Pulsating", 
            "Delicious", 
            "Setting", 
            "Disputing", 
            "Crying", 
            "Coiling", 
            "Rising", 
            "Choosing", 
            "Heartless", 
            "Entwined", 
            "Sacred", 
            "Upfront", 
            "Fly Away", 
            "Heavenly", 
            "Truthful", 
            "Halberd", 
            "Warm", 
            "Rough Song", 
            "Unseeing", 
            "Harvesting", 
            "Croaking", 
            "Overjoyed", 
            "Graceful", 
            "Agonizing", 
            "Piling", 
            "Wandering", 
            "Unknowing", 
            "Saddened", 
            "Counting", 
            "Decadent", 
            "Beloved", 
            "Fattening", 
            "Roaring", 
            "Protected", 
            "Closed", 
            "Freezing", 
            "Immovable", 
            "Dawning", 
            "Starting"
        };
        public static string[] Second =
        {
            "Wrath", 
            "Swift", 
            "Black", 
            "Ruined", 
            "Honor", 
            "Marble’s", 
            "Military", 
            "Vane", 
            "Daybreak’s", 
            "Kourin’s", 
            "Humbling", 
            "Heretic’s", 
            "Dusk’s", 
            "Cupola", 
            "Friend’s", 
            "Forbidden", 
            "Idling", 
            "Retuning", 
            "Cupid’s", 
            "Fortune’s", 
            "Mourning", 
            "Medium’s", 
            "Leading", 
            "Cursed", 
            "Obsessive", 
            "Season’s", 
            "Advice’s", 
            "Failing", 
            "Unlimited", 
            "Past’s", 
            "Eternity’s", 
            "Gray", 
            "Gambler’s", 
            "Starting", 
            "Joyous", 
            "Blazing", 
            "Doomed", 
            "Your"
        };
        public static string[] Third =
        {
            "Two_Wings",
            "Phoenix",
            "Hand_Song",
            "Pure_Bred",
            "Fast_Horse",
            "Nemesis",
            "Alga_Grass",
            "Old World",
            "Princess",
            "Phantom",
            "Paradise",
            "Masquerade",
            "Holy_Ground",
            "Bulwark",
            "Freedom",
            "1000_Oaks",
            "Slacker",
            "Drunkard",
            "Exile",
            "Empire",
            "Metal_Doll",
            "Weed_Eater",
            "Night_Moon",
            "Tiny_Beast",
            "Footsteps",
            "Whicker",
            "Offerings",
            "Pilgrim",
            "Venom_Fang",
            "March",
            "Ocean",
            "Fountain",
            "Life_Boat",
            "Bodhi_Tree",
            "Snow_Lamp",
            "Cathedral",
            "Puddle",
            "Frog_Lake",
            "Blue_Cloud",
            "Scud",
            "Gold_Bird",
            "Dark_Tree",
            "Vagabond",
            "Evergreen",
            "Malt_Town",
            "Ignorance",
            "Globe",
            "Snow_Caps",
            "Foot_Stone",
            "Holy_Relic",
            "Whiplash",
            "Fortune",
            "Resort",
            "Cassiopeia",
            "Shadow",
            "Berserker"
        };

        public List<string[]> GetAll() => new List<string[]>{First, Second,Third};

        public string[] this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0:
                        return First;
                        break;
                    
                    case 1:
                        return Second;
                        break;
                    
                    case 2:
                        return Third;
                        break;
                    
                    default:
                        throw new ArgumentOutOfRangeException("i", "Parameter must be between 0 and 2");
                }
            }
        }
        
        }
}