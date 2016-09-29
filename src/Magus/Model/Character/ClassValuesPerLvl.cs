using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class ClassValuesPerLvl {

        List<Perk> perks;
        int attackValue;
        int vitalityValue;
        int agilityValue;
        int wisdomValue;
        int atLvl;

        public ClassValuesPerLvl() {
            perks = new List<Perk>();
            attackValue = 0;
            vitalityValue = 0;
            agilityValue = 0;
            wisdomValue = 0;
            atLvl = 0;
        }

        public ClassValuesPerLvl(List<Perk> perks, int attackValue, int vitalityValue, int agilityValue, int wisdomValue, int atLvl) {
            this.perks = perks;
            this.attackValue = attackValue;
            this.vitalityValue = vitalityValue;
            this.agilityValue = agilityValue;
            this.wisdomValue = wisdomValue;
            this.atLvl = atLvl;
        }

        public List<Perk> Perks {
            get { return perks; }
            set { this.perks = value; }
        }
        public int AttackValue {
            get { return attackValue; }
            set { this.attackValue = value; }
        }
        public int VitalityValue {
            get { return vitalityValue; }
            set { this.vitalityValue = value; } 
        }
        public int AgilityValue {
            get { return agilityValue; }
            set { this.agilityValue = value; }
        }
        public int WisdomValue {
            get { return wisdomValue; }
            set { this.wisdomValue = value; }
        }
        public int ValuesAtLvl {
            get { return atLvl; }
            set { this.atLvl = value; }
        }

    }
}
