using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Songs {

        static ObservableCollection<Song> musics;

        private static Songs instance = null;

        private Songs() {
            musics = new ObservableCollection<Song>();
        }

        public static Songs Instance {
            get {
                if (instance == null) {
                    instance = new Songs();
                }
                return instance;
            }
        }

        public static ObservableCollection<Song> getSongs() {
            return musics;
        }

    }
}
