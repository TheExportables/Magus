using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Perk {

        String name;
        String description;
        List<Perk> perkRequirements;
        List<SkillRequirement> skillRequirements;

        public Perk() {
            name = null;
            description = null;
            perkRequirements = new List<Perk>();
            skillRequirements = new List<SkillRequirement>();
        }

        public String Name {
            get { return name; }
            set { this.name = value; }
        }
        public String Description {
            get { return description; }
            set { this.description = value; }
        }
        public List<Perk> PerkRequirements {
            get { return perkRequirements; }
            set { this.perkRequirements = value; }
        }
        public List<SkillRequirement> SkillRequirements {
            get { return skillRequirements; }
            set { this.skillRequirements = value; }
        }
    }
}