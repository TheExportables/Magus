using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class MagicSpell : Spell {

        int costPerStr;
        bool usesPsi;

        public MagicSpell() : base() {
            costPerStr = 1;
            usesPsi = false;
        }

        public MagicSpell(String name, String description, int duration, String range, int castTime, String affects, ResistanceType rtype, int str, int costPerStr, bool usesPsi) : base(name, description, duration, range, castTime, affects, rtype, str) {
            this.costPerStr = costPerStr;
            this.usesPsi = usesPsi;
        }

        public int CostPerStr {
            get { return costPerStr; }
            set { this.costPerStr = value; }
        }
        public bool UsesPsi {
            get { return usesPsi; }
            set { this.usesPsi = value; }
        }
    }
}