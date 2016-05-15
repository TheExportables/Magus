using Magus.Model;
using Magus.Model.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.ViewModel {
    class ItemViewModel {
        
        Item item;
        Material material;

        public ItemViewModel(Item item) {
            this.item = item;
            this.material = new Material();
        }

        public ItemViewModel(Item item, Material material) {
            this.item = item;
            this.material = material;
        }

        public Item Item {
            get { return item; }
            set { this.item = value; }
        }

        public Material Material {
            get { return material; }
            set { this.material = value; } 
        }
    }
}
