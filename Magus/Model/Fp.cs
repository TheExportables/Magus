using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Fp {

        int currFp;
        int maxFp;

        public Fp() {
            maxFp = 0;
            currFp = maxFp;
        }

        public Fp(int fp) {
            maxFp = fp;
            currFp = maxFp;
        }

        public int CurrFp {
            get {
                return currFp;
            }
        }

        public int MaxFp {
            get {
                return maxFp;
            }
        }

        public void sufferDamage(int dmg) {
            currFp -= dmg;
            if (currFp < 0)
                currFp = 0;
        }

        public void heal(int healAmount) {
            if (currFp < maxFp) {
                currFp += healAmount;
                if (currFp > maxFp)
                    currFp = maxFp;
            }
        }

        public void increaseFp(int amount) {
            currFp += amount;
            maxFp += amount;
        }

        public void decreaseFp(int amount) {
            currFp -= amount;
            maxFp -= amount;
            if (currFp < 0)
                currFp = 0;
            if (maxFp < 0)
                maxFp = 0;
        }

        public bool isExhausted() {
            if (currFp == 0 || maxFp == 0) {
                return true;
            } else
                return false;
        }

        public bool isTired() {
            if (currFp <= maxFp / 4) {
                return true;
            } else
                return false;
        }
    }
}