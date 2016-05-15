using Magus.Model.Abilities;
using System;
using System.Collections.Generic;

namespace Magus.Model {
    class Perk {

        String name;
        String description;
        List<Perk> perkRequirements;
        List<SkillRequirement> skillRequirements;
        List<StatRequirement> statRequirements;
        PerkCategory category;

        public Perk() {
            name = null;
            description = null;
            perkRequirements = new List<Perk>();
            skillRequirements = new List<SkillRequirement>();
            statRequirements = new List<StatRequirement>();
            category = PerkCategory.Common;
        }

        public Perk(String name, String desc, List<Perk> perkReqs, List<SkillRequirement> skillReqs, List<StatRequirement> statReqs, PerkCategory category) {
            this.name = name;
            this.description = desc;
            this.perkRequirements = perkReqs;
            this.skillRequirements = skillReqs;
            this.statRequirements = statReqs;
            this.category = category;
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
        public List<StatRequirement> StatRequirements {
            get { return statRequirements; }
            set { statRequirements = value; }
        }
        public PerkCategory Category {
            get { return category; }
            set { this.category = value; }
        }
    }
}