using System;

namespace Modulo2Semana5 {
    static class PartidaBatalha {
        public static Robo Batalhar(Robo robo1, Robo robo2) {
            Robo? vencedor = null;
            int rodadas = 0;
            while (robo1.PontosDeVida > 0 && robo2.PontosDeVida > 0 && rodadas < 10) {
                robo1.ReduzirPontosVida(robo1.CausarDano());
                robo2.ReduzirPontosVida(robo2.CausarDano());
                rodadas++;
                Console.WriteLine($"Rodada {rodadas}: {robo1.Nome} {robo1.PontosDeVida} vs {robo2.Nome} {robo2.PontosDeVida}");
            }
            if (robo1.PontosDeVida > 0) {
                vencedor = robo1;
            }
            else if (robo2.PontosDeVida > 0) {
                vencedor = robo2;
            }
            else {
                if (robo1.PontosDeVida > robo2.PontosDeVida) {
                    vencedor = robo1;
                }
                else {
                    vencedor = robo2;
                }
            }
            return vencedor;
        }
    }
}
