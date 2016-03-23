using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Cash {
        int goldAmount;
        int silverAmount;
        int copperAmount;

        public Cash() {
            goldAmount = 0;
            silverAmount = 0;
            copperAmount = 0;
        }
        
        public int GoldAmount {
            get { return goldAmount; }
            set { this.goldAmount = value; }
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
        }

        public int convertToCopper() {
            int copper = goldAmount * 1000 + silverAmount * 100 + copperAmount;
            return copper;
        }
    }
}