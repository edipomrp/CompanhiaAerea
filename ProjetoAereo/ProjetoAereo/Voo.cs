using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAereo
{
    class Voo {
        public String origem { get; set;} 
        public String destino { get; set;}
        public String horario { get; set;}
        public ArrayList passageiros { get; set;}
        public Queue<Pessoa> filaEspera { get; set; } = new Queue<Pessoa>();

        public Voo(String origem, String destino, String horario, ArrayList passageiros) {
            this.origem = origem;
            this.destino = destino;
            this.horario = horario;
            this.passageiros = passageiros;
        }
        


    }
}
