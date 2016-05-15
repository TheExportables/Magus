using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model.Magic {
    class GiftOfGods {
        String name;
        String description;

        public GiftOfGods() {
            name = null;
            description = null;
        }

        public GiftOfGods(String name, String desc) {
            this.name = name;
            this.description = desc;
        }

        public String Name {
            get { return name; }
            set { this.name = value; }
        }
        public String Description {
            get { return description; }
            set { this.description = value; }
        }
    }
}
