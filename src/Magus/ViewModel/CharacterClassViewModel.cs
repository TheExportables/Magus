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
            lvl = 0;
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
                return characterClass.ValuesPerLvl.ElementAt(lvl - 1).AttackValue;
            else
                return characterClass.ValuesPerLvl.ElementAt(lvl - 1).AttackValue - characterClass.ValuesPerLvl.ElementAt(lvl - 2).AttackValue;

        }

        public int getVitalityValue() {
            if (lvl <= 1)
                return characterClass.ValuesPerLvl.ElementAt(lvl - 1).VitalityValue;
            else
                return characterClass.ValuesPerLvl.ElementAt(lvl - 1).VitalityValue - characterClass.ValuesPerLvl.ElementAt(lvl - 2).VitalityValue;
        }

        public int getAgilityValue() {
            if (lvl <= 1)
                return characterClass.ValuesPerLvl.ElementAt(lvl - 1).AgilityValue;
            else
                return characterClass.ValuesPerLvl.ElementAt(lvl - 1).AgilityValue - characterClass.ValuesPerLvl.ElementAt(lvl - 2).AgilityValue;
        }

        public int getWisdomValue() {
            if (lvl <= 1)
                return characterClass.ValuesPerLvl.ElementAt(lvl - 1).WisdomValue;
            else
                return characterClass.ValuesPerLvl.ElementAt(lvl - 1).WisdomValue - characterClass.ValuesPerLvl.ElementAt(lvl - 2).WisdomValue;
        }
        #endregion
    }
}
