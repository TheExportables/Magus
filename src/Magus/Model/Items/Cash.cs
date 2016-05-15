using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Cash {
        int mithrilAmount;
        int goldAmount;
        int silverAmount;
        int copperAmount;

        public Cash() {
            mithrilAmount = 0;
            goldAmount = 0;
            silverAmount = 0;
            copperAmount = 0;
        }

        public Cash(int m, int g, int s, int c) {
            this.mithrilAmount = m;
            this.goldAmount = g;
            this.silverAmount = s;
            this.copperAmount = c;
        }

        public int MithrilAmount {
            get { return mithrilAmount; }
            set { this.mithrilAmount = value; }
        }
        public int GoldAmount {
            get { return goldAmount; }
            set { 
                this.goldAmount = value;
                calculateCash();
            }
        }
        public int SilverAmount {
            get { return silverAmount; }
            set { 
                this.silverAmount = value;
                calculateCash();
            }
        }
        public int CopperAmount {
            get { return copperAmount; }
            set { 
                this.copperAmount = value;
                calculateCash();
            }
        }

        private void calculateCash() {
            if (copperAmount > 100) {
                silverAmount += copperAmount / 100;
                copperAmount = copperAmount % 100;
            }
            if (silverAmount > 10) {
                goldAmount += silverAmount / 10;
                silverAmount = silverAmount % 10;
            }
            if (goldAmount > 100) {
                mithrilAmount += goldAmount / 100;
                goldAmount = goldAmount % 100;
            }
        }

        public int convertToCopper() {
            int copper = mithrilAmount * 100000 + goldAmount * 1000 + silverAmount * 100 + copperAmount;
            return copper;
        }
    }
}