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