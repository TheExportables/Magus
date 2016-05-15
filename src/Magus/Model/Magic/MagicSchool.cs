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
        int psiMultiplier;

        public MagicSchool() {
            name = "";
            description = "";
            schoolMasteries = new List<MagicMastery>();
            manaPerLvl = 0;
            psiMultiplier = 0;
        }

        public MagicSchool(String name, String desc, List<MagicMastery> masteries, int manaPerLvl, int psimulti) {
            this.name = name;
            this.description = desc;
            this.schoolMasteries = masteries;
            this.manaPerLvl = manaPerLvl;
            this.psiMultiplier = psimulti;
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
        public int PsiMultiplier {
            get { return psiMultiplier; }
            set { psiMultiplier = value; }
        }
    }
}