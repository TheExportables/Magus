using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Skill {

        String name;
        String description;
        int value;
        int lvl;
        int modifier;
        StatDependency dependency;
        int other;
        bool canBeObjected;
        bool trainedOnly;

        public Skill() {
            name = null;
            description = null;
            value = 0;
            lvl = 0;
            modifier = 0;
            other = 0;
            canBeObjected = false;
            trainedOnly = false;
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
        public int Value {
            get { return value; }
        }
        public int Lvl {
            get { return lvl; }
            set { 
                this.lvl = value;
                calculateValue();
            }
        }
        public int Modifier {
            get { return modifier; }
            set { 
                this.modifier = value;
                calculateValue();
            }
        }
        public StatDependency Dependency {
            get { return dependency; }
            set { this.dependency = value; }
        }
        public int Other {
            get { return other; }
            set { 
                this.other = value;
                calculateValue();
            }
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

        private void calculateValue() {
            value = lvl + modifier + other;
        }
    }
}