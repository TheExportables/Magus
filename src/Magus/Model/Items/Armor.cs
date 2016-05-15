using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Armor : Item {

        int maxDexModifier;
        int blockValue;
        int movementObjection;

        public Armor() : base() {
            maxDexModifier = 0;
            blockValue = 0;
            movementObjection = 0;
        }

        public Armor(String name, Cash cost, int weight, bool masterpiece, String material, int maxDexMod, int blockVal, int movObjection) : base(name, cost, weight, masterpiece, material) {
            this.maxDexModifier = maxDexMod;
            this.blockValue = blockVal;
            this.movementObjection = movObjection;
        }

        public int MaxDexModifier {
            get { return maxDexModifier; }
            set { this.maxDexModifier = value; }
        }
        public int BlockValue {
            get { return blockValue; }
            set { this.blockValue = value; }
        }
        public int MovementObjection {
            get { return movementObjection; }
            set { this.movementObjection = value; }
        }
    }
}