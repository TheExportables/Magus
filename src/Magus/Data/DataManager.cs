using Magus.Model;
using Magus.Model.Items;
using Magus.Model.Magic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Data {
    class DataManager {

        static ObservableCollection<Race> races;
        static ObservableCollection<CharacterClass> classes;
        static ObservableCollection<Perk> perks;
        static ObservableCollection<Skill> skills;
        static ObservableCollection<Item> commonItems;
        static ObservableCollection<Armor> armors;
        static ObservableCollection<Shield> shields;
        static ObservableCollection<Weapon> weapons;
        static ObservableCollection<Material> materials;
        static ObservableCollection<PriestDeity> deities;
        static ObservableCollection<MagicSchool> magicSchools;

        private static DataManager instance = null;

        private DataManager() {
            races = new ObservableCollection<Race>();
            classes = new ObservableCollection<CharacterClass>();
            perks = new ObservableCollection<Perk>();
            skills = new ObservableCollection<Skill>();
            commonItems = new ObservableCollection<Item>();
            armors = new ObservableCollection<Armor>();
            shields = new ObservableCollection<Shield>();
            weapons = new ObservableCollection<Weapon>();
            materials = new ObservableCollection<Material>();
            deities = new ObservableCollection<PriestDeity>();
            magicSchools = new ObservableCollection<MagicSchool>();
        }

        public static DataManager Instance {
            get {
                if (instance == null) {
                    instance = new DataManager();
                }
                return instance;
            }
        }

        public static ObservableCollection<Race> Races {
            get { return races; }
            set { races = value; }
        }

        public static ObservableCollection<CharacterClass> Classes {
            get { return classes; }
            set { classes = value; }
        }

        public static ObservableCollection<Perk> Perks {
            get { return perks; }
            set { perks = value; }
        }

        public static ObservableCollection<Skill> Skills {
            get { return skills; }
            set { skills = value; }
        }

        public static ObservableCollection<Item> CommonItems {
            get { return commonItems; }
            set { commonItems = value; }
        }

        public static ObservableCollection<Armor> Armors {
            get { return armors; }
            set { armors = value; }
        }

        public static ObservableCollection<Shield> Shields {
            get { return shields; }
            set { shields = value; }
        }

        public static ObservableCollection<Weapon> Weapons {
            get { return weapons; }
            set { weapons = value; }
        }

        public static ObservableCollection<Material> Materials {
            get { return materials; }
            set { materials = value; }
        }

        public static ObservableCollection<PriestDeity> Deities {
            get { return deities; }
            set { deities = value; }
        }

        public static ObservableCollection<MagicSchool> MagicShools {
            get { return magicSchools; }
            set { magicSchools = value; }
        }
    }
}
