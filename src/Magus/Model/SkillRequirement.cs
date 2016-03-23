using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class SkillRequirement {

        Skill requiredSkill;
        int minLvl;

        public SkillRequirement() {
            requiredSkill = new Skill();
            minLvl = 0;
        }

        public SkillRequirement(Skill skill, int minLvl) {
            this.requiredSkill = skill;
            this.minLvl = minLvl;
        }

        public Skill RequiredSkill {
            get { return requiredSkill; }
            set { this.requiredSkill = value; }
        }
        public int MinLvl {
            get { return minLvl; }
            set { this.minLvl = value; }
        }
    }
}