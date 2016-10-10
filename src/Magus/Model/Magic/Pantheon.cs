using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model.Magic {
    class Pantheon {

        string name;
        List<PriestDeity> gods;

        public Pantheon() {
            name = "";
            gods = new List<PriestDeity>();
        }

        public Pantheon(string name, List<PriestDeity> gods) {
            this.name = name;
            this.gods = gods;
        }

        public string Name {
            get { return name; }
            set { this.name = value; }
        }

        public List<PriestDeity> Gods {
            get { return gods; }
            set { this.gods = value; }
        }
    }
}
