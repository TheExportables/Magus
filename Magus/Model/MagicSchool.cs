using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class MagicSchool {

        String name;
        String description;
        List<MagicMastery> schoolMasteries;
        int manaPerLvl;

        public MagicSchool() {
            name = null;
            description = null;
            schoolMasteries = new List<MagicMastery>();
        }

        public String Name {
            get { return name; }
            set { this.name = value; }
        }
        public String Description {
            get { return description; }
            set { this.description = value; }
        }
        public List<MagicMastery> SchoolMasteries {
            get { return schoolMasteries; }
            set { this.schoolMasteries = value; }
        }
        public int ManaPerLvl {
            get { return manaPerLvl; }
            set { this.manaPerLvl = value; }
        }
    }
}