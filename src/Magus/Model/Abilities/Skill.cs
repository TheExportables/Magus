using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Skill {

        String name;
        String description;
        StatDependency dependency;
        bool canBeObjected;
        bool trainedOnly;

        public Skill() {
            name = null;
            description = null;
            canBeObjected = false;
            trainedOnly = false;
        }

        public Skill(String name, String desc, StatDependency dependency, bool canBeObjected, bool trainedOnly) {
            this.name = name;
            this.description = desc;
            this.dependency = dependency;
            this.canBeObjected = canBeObjected;
            this.trainedOnly = trainedOnly;
        }

        #region getters and setters
        public String Name {
            get { return name; }
            set { this.name = value; }
        }
        public String Description {
            get { return description; }
            set { this.description = value; }
        }
        public StatDependency Dependency {
            get { return dependency; }
            set { this.dependency = value; }
        }
        public bool CanBeObjected {
            get { return canBeObjected; }
            set { this.canBeObjected = value; }
        }
        public bool TrainedOnly {
            get { return trainedOnly; }
            set { this.trainedOnly = value; }
        }
        #endregion
    }
}