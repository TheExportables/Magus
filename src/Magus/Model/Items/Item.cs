using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Item {
        protected String name;
        protected Cash cost;
        protected int weight;
        protected bool masterpiece;
        protected String material;

        public Item() {
            name = null;
            cost = new Cash();
            weight = 0;
            masterpiece = false;
            material = "";
        }

        public Item(String name, Cash cost, int weight, bool masterpiece, String material) {
            this.name = name;
            this.cost = cost;
            this.weight = weight;
            this.masterpiece = masterpiece;
            this.material = material;
        }

        public String Name {
            get { return name; }
            set { this.name = value; }
        }
        public Cash Cost {
            get { return cost; }
            set { this.cost = value; }
        }
        public int Weight {
            get { return weight; }
            set { this.weight = value; }
        }
    }
}