using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model.Magic {
    class PriestDeity {
        String name;
        String description;
        List<GreaterSphere> greaterSpheres;
        List<SmallerSphere> smallerSpheres;

        public PriestDeity() {
            name = "";
            description = "";
            greaterSpheres = new List<GreaterSphere>();
            smallerSpheres = new List<SmallerSphere>();
        }

        public PriestDeity(String name, String description, List<GreaterSphere> greaterSpheres, List<SmallerSphere> smallerSpheres) {
            this.name = name;
            this.description = description;
            this.greaterSpheres = greaterSpheres;
            this.smallerSpheres = smallerSpheres;
        }

        public String Name {
            get { return name; }
            set { name = value; }
        }

        public String Description {
            get { return description; }
            set { description = value; }
        }

        public List<GreaterSphere> GreaterSpheres {
            get { return greaterSpheres; }
            set { greaterSpheres = value; }
        }

        public List<SmallerSphere> SmallerSpheres {
            get { return smallerSpheres; }
            set { smallerSpheres = value; }
        }
    }
}
