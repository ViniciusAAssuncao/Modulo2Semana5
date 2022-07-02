using System;

namespace Modulo2Semana5 {
    internal class RoboBatalhaLeve : Robo {
        public override int CausarDano() {
            if (Status == "Ligado") {
                return 10;
            }
            else {
                return 0;
            }
        }
    }
}
