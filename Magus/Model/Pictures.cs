using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
   class Pictures {

        static ObservableCollection<Picture> pics;

        private static Pictures instance = null;

        private Pictures() {
            pics = new ObservableCollection<Picture>();
        }

        public static Pictures Instance {
            get {
                if (instance == null) {
                    instance = new Pictures();
                }
                return instance;
            }
        }

        public static ObservableCollection<Picture> getPictures() {
            return pics;
        }

    }
}