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

        public Item() {
            name = null;
            cost = new Cash();
            weight = 0;
        }

        public Item(String name, Cash cost, int weight) {
            this.name = name;
            this.cost = cost;
            this.weight = weight;
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