using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class Messages {

        static ObservableCollection<Message> texts;

        private static Messages instance = null;

        private Messages() {
            texts = new ObservableCollection<Message>();
        }

        public static Messages Instance {
            get {
                if (instance == null) {
                    instance = new Messages();
                }
                return instance;
            }
        }

        public static ObservableCollection<Message> getMessages() {
            return texts;
        }

    }
}
