using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class CharacterClass {

        String name;
        String description;
        int lvl;
        List<int> attackValues;
        List<int> vitalityValues;
        List<int> agilityValues;
        List<int> wisdomValues;
        int spPerLvl;
        DiceValue fpPerLvl;

        public CharacterClass() {
            name = null;
            description = null;
            lvl = 0;
            attackValues = new List<int>();
            vitalityValues = new List<int>();
            agilityValues = new List<int>();
            wisdomValues = new List<int>();
            spPerLvl = 0;
            fpPerLvl = new DiceValue();
        }

        #region getters and setters
        public String Name {
            get { return name; }
            set { this.name = value; }
        }
        public String Description {
            get { return description; }
            set { this.description = value; }
        }
        public int Lvl {
            get { return lvl; }
            set { this.lvl = value; }
        }
        public List<int> AttackValues {
            get { return attackValues; }
            set { this.attackValues = value; }
        }
        public List<int> Vitality {
            get { return vitalityValues; }
            set { this.vitalityValues = value; }
        }
        public List<int> Agility {
            get { return agilityValues; }
            set { this.agilityValues = value; }
        }
        public List<int> Wisdom {
            get { return wisdomValues; }
            set { this.wisdomValues = value; }
        }
        public int SpPerLvl {
            get { return spPerLvl; }
            set { this.spPerLvl = value; }
        }
        public DiceValue FpPerLvl {
            get { return fpPerLvl; }
            set { this.fpPerLvl = value; }
        }
        #endregion

        #region future VM logic
        public int getAttackValue() {
            if (lvl <= 1)
                return attackValues.ElementAt(lvl - 1);
            else
                return attackValues.ElementAt(lvl - 1)-attackValues.ElementAt(lvl-2);

        }

        public int getVitalityValue() {
            if (lvl <= 1)
                return vitalityValues.ElementAt(lvl - 1);
            else
                return vitalityValues.ElementAt(lvl - 1) - vitalityValues.ElementAt(lvl - 2);
        }

        public int getAgilityValue() {
            if (lvl <= 1)
                return agilityValues.ElementAt(lvl - 1);
            else
                return agilityValues.ElementAt(lvl - 1) - agilityValues.ElementAt(lvl - 2);
        }

        public int getWisdomValue() {
            if (lvl <= 1)
                return wisdomValues.ElementAt(lvl - 1);
            else
                return wisdomValues.ElementAt(lvl - 1) - wisdomValues.ElementAt(lvl - 2);
        }
        #endregion

    }
}