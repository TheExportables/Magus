using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class MagicMastery {

        String name;
        String description;
        List<Spell> spells;
        int lvl;

        public MagicMastery() {
            name = null;
            description = null;
            spells = new List<Spell>();
            lvl = 2;
        }

        public String Name {
            get { return name; }
            set { this.name = value; }
        }
        public String Description {
            get { return description; }
            set { this.description = value; }
        }
        public List<Spell> Spells {
            get { return spells; }
            set { this.spells = value; }
        }
        public int Lvl {
            get { return lvl; }
            set { this.lvl = value; }
        }
    }
}