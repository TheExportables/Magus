using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model.Magic {
    class GreaterSphere {

        String name;
        List<Skill> primarySkills;
        List<Perk> perks;

        public GreaterSphere() {
            name = null;
            primarySkills = new List<Skill>();
            perks = new List<Perk>();
        }

        public GreaterSphere(String name, List<Skill> ps, List<Perk> p) {
            this.name = name;
            this.primarySkills = ps;
            this.perks = p;
        }

        public String Name {
            get { return name; }
            set { this.name = value; } 
        }
        public List<Skill> PrimarySkills {
            get { return primarySkills; }
            set { this.primarySkills = value; } 
        }
        public List<Perk> Perks {
            get { return perks; }
            set { this.perks = value; } 
        }

    }
}
