using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAereo
{
    class Endereco {
        public String rua { get; set; }
        public int numero { get; set; }
        public String bairro { get; set; }
        public String cidade { get; set; }

        public Endereco(String rua, int numero, String bairro, String cidade) {
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
        }
    }
}
