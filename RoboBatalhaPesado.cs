using System;

namespace Modulo2Semana5 {
    internal class RoboBatalhaPesado : Robo {
        public override int CausarDano() {
            Status = "Aguardando";
            return 20;
        }
    }
}
