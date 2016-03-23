using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Hp {

        int currHp;
        int maxHp;

        public Hp() {
            maxHp = 0;
            currHp = maxHp;
        }

        public Hp(int hp) {
            maxHp = hp;
            currHp = maxHp;
        }

        public int CurrHp {
            get {
                return currHp;
            }
        }

        public int MaxHp {
            get {
                return maxHp;
            }
        }

        public void sufferDamage(int dmg) {
            currHp -= dmg;
            if (currHp < 0)
                currHp = 0;
        }

        public void heal(int healAmount) {
            if (currHp < maxHp) {
                currHp += healAmount;
                if (currHp > maxHp)
                    currHp = maxHp;
            }
        }

        public void increaseHp(int amount) {
            currHp += amount;
            maxHp += amount;
        }

        public void decreaseHp(int amount) {
            currHp -= amount;
            maxHp -= amount;
            if (currHp < 0)
                currHp = 0;
            if (maxHp < 0)
                maxHp = 0;
        }

        public bool isDying() {
            if (currHp == 0 || maxHp == 0) {
                return true;
            } else
                return false;
        }

        public bool isUnableToFight() {
            if (currHp <= maxHp / 4) {
                return true;
            } else
                return false;
        }
    }
}