using System;
using EStatus;

namespace Modulo2Semana5 {
    abstract class Robo {
        private string nome;
        private int pontosDeVida;
        private string status;
        public string Nome {
            get {
                return nome;
            }
            set {
                nome = value;
            }
        }
        public int PontosDeVida {
            get {
                return pontosDeVida;
            }
            set {
                pontosDeVida = value;
            }
        }
        public string Status {
            get {
                return status;
            }
            set {
                status = value;
            }
        }
        public Robo(string nome) {
            this.nome = nome;
            this.pontosDeVida = 100;
            this.status = "Desligado";
        }
        public void Iniciar() {
            status = "Ligado";
        }
        public void Parar() {
            status = "Desligado";
        }
        public abstract int CausarDano();

        public void ReduzirPontosVida(int dano) {
            pontosDeVida -= dano;
            if (pontosDeVida <= 0) {
                status = "Destruído";
            }
        }
    }
}
