using Magus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.ViewModel {
    class MagicMasteryViewModel {

        MagicMastery magicMastery;
        int lvl;

        public MagicMasteryViewModel(MagicMastery magicMastery) {
            this.magicMastery = magicMastery;
            lvl = 2;
        }

        public int Lvl {
            get { return lvl; }
            set { this.lvl = value; }
        }

        public MagicMastery mastery {
            get { return magicMastery; }
        }
    }
}
