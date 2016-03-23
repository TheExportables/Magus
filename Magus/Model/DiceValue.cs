using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magus.Model {
    class DiceValue {

        int multiplier;
        Dice diceType;

        public DiceValue() {
        }

        public DiceValue(int multiplier, Dice dice) {
            this.multiplier = multiplier;
            this.diceType = dice;
        }

        public int Multiplier {
            get {
                return multiplier;
            }
            set {
                this.multiplier = value;
            }
        }

        public Dice DiceType {
            get {
                return diceType;
            }
            set {
                this.diceType = value;
            }
        }

        public List<int> generateValue() {
            List<int> generatedNumbers = new List<int>();
            Random r = new Random();
            int range;
            switch(diceType){
                case Dice.d4:
                    range = 4;
                    break;
                case Dice.d6:
                    range = 6;
                    break;
                case Dice.d8:
                    range = 8;
                    break;
                case Dice.d10:
                    range = 10;
                    break;
                case Dice.d20:
                    range = 20;
                    break;
                default:
                    range = 20;
                    break;
            }
            for (int i = 0; i < multiplier; i++) { 
                generatedNumbers.Add(r.Next(1,range));
            }
            return generatedNumbers;
        }
    }
}