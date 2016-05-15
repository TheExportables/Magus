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

        public MagicMastery() {
            name = null;
            description = null;
            spells = new List<Spell>();
        }

        public MagicMastery(String name, String desc, List<Spell> spells) {
            this.name = name;
            this.description = desc;
            this.spells = spells;
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
    }
}