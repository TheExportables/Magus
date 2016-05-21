using Magus.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class CharacterClass {

        String name;
        String description;
        ObservableCollection<ClassValuesPerLvl> valuesPerLvl;
        int spPerLvl;
        DiceValue fpPerLvl;

        public CharacterClass() {
            name = "";
            description = "";
            valuesPerLvl = new ObservableCollection<ClassValuesPerLvl>();
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
        public ObservableCollection<ClassValuesPerLvl> ValuesPerLvl {
            get { return valuesPerLvl; }
            set { this.valuesPerLvl = value; }
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