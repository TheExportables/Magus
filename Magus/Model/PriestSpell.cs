using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class PriestSpell : Spell {

        int faith;
        List<MagicMastery> supports;
        List<MagicMastery> oppositional;

        public PriestSpell() : base() {
            faith = 0;
            supports = new List<MagicMastery>();
            oppositional = new List<MagicMastery>();
        }

        public int Faith {
            get { return faith; }
            set { this.faith = value; }
        }
        public List<MagicMastery> Supports {
            get { return supports; }
            set { this.supports = value; }
        }
        public List<MagicMastery> Oppositional {
            get { return oppositional; }
            set { this.oppositional = value; }
        }
    }
}