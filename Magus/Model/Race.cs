using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Race {

        String name;
        int strengthModifier;
        int dextirityModifier;
        int enduranceModifier;
        int intellectModifier;
        int willpowerModifier;
        int charismModifier;

        public String Name {
            get { return name; }
            set { name = value; }
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