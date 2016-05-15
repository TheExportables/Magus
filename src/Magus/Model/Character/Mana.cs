using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Mana {

        int currMana;
        int maxMana;

        public Mana() {
            maxMana = 0;
            currMana = maxMana;
        }

        public Mana(int mp) {
            maxMana = mp;
            currMana = maxMana;
        }

        public int CurrMp {
            get {
                return currMana;
            }
        }

        public int MaxMp {
            get {
                return maxMana;
            }
        }

        public void castSpell(int cost) {
            currMana -= cost;
            if (currMana < 0)
                currMana = 0;
        }

        public void chargeMana(int amount) {
            if (currMana < maxMana) {
                currMana += amount;
                if (currMana > maxMana)
                    currMana = maxMana;
            }
        }

        public void increaseMp(int amount) {
            currMana += amount;
            maxMana += amount;
        }

        public void decreaseMp(int amount) {
            currMana -= amount;
            maxMana -= amount;
            if (currMana < 0)
                currMana = 0;
            if (maxMana < 0)
                maxMana = 0;
        }

    }
}