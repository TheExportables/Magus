using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class CharacterClass {

        String name;
        String description;
        List<int> attackValues;
        List<int> vitalityValues;
        List<int> agilityValues;
        List<int> wisdomValues;
        int spPerLvl;
        DiceValue fpPerLvl;

        public CharacterClass() {
            name = "";
            description = "";
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
        public List<int> AttackValues {
            get { return attackValues; }
            set { this.attackValues = value; }
        }
        public List<int> VitalityValues {
            get { return vitalityValues; }
            set { this.vitalityValues = value; }
        }
        public List<int> AgilityValues {
            get { return agilityValues; }
            set { this.agilityValues = value; }
        }
        public List<int> WisdomValues {
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

    }
}