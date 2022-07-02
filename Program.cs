using System;

namespace Modulo2Semana5 {
    class Program {
        static void Main(string[] args) {
            Robo robo1 = new RobodeBatalhaPesado();
            Robo robo2 = new RoboDeBatalhaLeve();
            robo1.Nome = "Robo de Batalha Pesado";
            robo2.Nome = "Robo de Batalha Leve";
            robo1.Iniciar();
            robo2.Iniciar();
            Resultado resultado = PartidaBatalha.Batalhar(robo1, robo2);
            if (resultado.Empate) {
                Console.WriteLine("Empate!");
            }
            else {
                Console.WriteLine($"Vencedor: {resultado.Vencedor.Nome}");
            }
        }
    }
    }
}