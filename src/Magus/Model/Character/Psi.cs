using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Psi {

        int currPsi;
        int maxPsi;

        public Psi() {
            maxPsi = 0;
            currPsi = maxPsi;
        }

        public Psi(int psi) {
            maxPsi = psi;
            currPsi = maxPsi;
        }

        public int CurrPsi {
            get {
                return currPsi;
            }
        }

        public int MaxPsi {
            get {
                return maxPsi;
            }
        }

        public void useDiscipline(int cost) {
            currPsi -= cost;
            if (currPsi < 0)
                currPsi = 0;
        }

        public void meditate(int amount) {
            if (currPsi < maxPsi) {
                currPsi += amount;
                if (currPsi > maxPsi)
                    currPsi = maxPsi;
            }
        }

        public void increasePsi(int amount) {
            currPsi += amount;
            maxPsi += amount;
        }

        public void decreasePsi(int amount) {
            currPsi -= amount;
            maxPsi -= amount;
            if (currPsi < 0)
                currPsi = 0;
            if (maxPsi < 0)
                maxPsi = 0;
        }

    }
}