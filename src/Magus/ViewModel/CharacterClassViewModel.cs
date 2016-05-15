using Magus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.ViewModel {
    class CharacterClassViewModel {

        CharacterClass characterClass;
        int lvl;

        public CharacterClassViewModel(CharacterClass characterClass) {
            this.characterClass = characterClass;
            lvl = 1;
        }

        public int Lvl {
            get { return lvl; }
            set { this.lvl = value; }
        }
        
        public CharacterClass CharClass {
            get { return characterClass; }
            set { this.characterClass = value; } 
        }

        #region future VM logic
        public int getAttackValue() {
            if (lvl <= 1)
                return characterClass.AttackValues.ElementAt(lvl - 1);
            else
                return characterClass.AttackValues.ElementAt(lvl - 1) - characterClass.AttackValues.ElementAt(lvl - 2);

        }

        public int getVitalityValue() {
            if (lvl <= 1)
                return characterClass.VitalityValues.ElementAt(lvl - 1);
            else
                return characterClass.VitalityValues.ElementAt(lvl - 1) - characterClass.VitalityValues.ElementAt(lvl - 2);
        }

        public int getAgilityValue() {
            if (lvl <= 1)
                return characterClass.AgilityValues.ElementAt(lvl - 1);
            else
                return characterClass.AgilityValues.ElementAt(lvl - 1) - characterClass.AgilityValues.ElementAt(lvl - 2);
        }

        public int getWisdomValue() {
            if (lvl <= 1)
                return characterClass.WisdomValues.ElementAt(lvl - 1);
            else
                return characterClass.WisdomValues.ElementAt(lvl - 1) - characterClass.WisdomValues.ElementAt(lvl - 2);
        }
        #endregion
    }
}
