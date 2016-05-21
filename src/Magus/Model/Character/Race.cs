using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Race {

        String name;
        String description;
        int strengthModifier;
        int dextirityModifier;
        int enduranceModifier;
        int intellectModifier;
        int willpowerModifier;
        int charismModifier;

        public Race() {
            name = "";
            description = "";
            strengthModifier = 0;
            dextirityModifier = 0;
            enduranceModifier = 0;
            intellectModifier = 0;
            willpowerModifier = 0;
            charismModifier = 0;
        }

        public Race(String name, String description, int strMod, int dexMod, int endMod, int intMod, int willMod, int charMod) {
            this.name = name;
            this.description = description;
            this.strengthModifier = strMod;
            this.dextirityModifier = dexMod;
            this.enduranceModifier = endMod;
            this.intellectModifier = intMod;
            this.willpowerModifier = willMod;
            this.charismModifier = charMod;
        }

        public String Name {
            get { return name; }
            set { name = value; }
        }

        public String Description {
            get { return description; }
            set { description = value; }
        }

        public int StrengthModifier {
            get { return strengthModifier; }
            set { strengthModifier = value; }
        }

        public int DextirityModifier {
            get { return dextirityModifier; }
            set { dextirityModifier = value; }
        }

        public int EnduranceModifier {
            get { return enduranceModifier; }
            set { enduranceModifier = value; }
        }

        public int IntellectModifier {
            get { return intellectModifier; }
            set { intellectModifier = value; }
        }

        public int WillpowerModifier {
            get { return willpowerModifier; }
            set { willpowerModifier = value; }
        }

        public int CharismModifier {
            get { return charismModifier; }
            set { charismModifier = value; }
        }

    }
}