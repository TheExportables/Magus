using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class AdventurerCharacterClass : CharacterClass {

        MagicSchool school;
        List<List<Perk>> perksPerLvl;
        List<String> availableForRaces;
        int attackValueRequirement;
        List<StatRequirement> statRequirements;
        List<SkillRequirement> skillRequirements;
        List<Perk> perkRequirements;
        string idealBackground;

        public AdventurerCharacterClass() : base() {
            school = null;
            perksPerLvl = new List<List<Perk>>();
            availableForRaces = new List<string>();
            attackValueRequirement = 0;
            statRequirements = new List<StatRequirement>();
            skillRequirements = new List<SkillRequirement>();
            perkRequirements = new List<Perk>();
            idealBackground = "";
        }

        public MagicSchool School {
            get { return school; }
            set { this.school = value; }
        }
        public List<List<Perk>> PerksPerLvl {
            get { return perksPerLvl; }
            set { this.perksPerLvl = value; }
        }
        public List<String> AvailableForRaces {
            get { return availableForRaces; }
            set { this.availableForRaces = value; }
        }
        public int AttackValueRequirement {
            get { return attackValueRequirement; }
            set { this.attackValueRequirement = value; }
        }
        public List<StatRequirement> StatRequirements {
            get { return statRequirements; }
            set { this.statRequirements = value; }
        }
        public List<SkillRequirement> SkillRequirements {
            get { return skillRequirements; }
            set { this.skillRequirements = value; }
        }
        public List<Perk> PerkRequirements {
            get { return perkRequirements; }
            set { this.perkRequirements = value; }
        }
        public String IdealBackground {
            get { return idealBackground; }
            set { this.idealBackground = value; }
        }
    }
}