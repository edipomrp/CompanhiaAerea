using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoAereo
{
    class Pessoa {
        public String cpf { get; set; }
        public String nome { get; set; }
        public String sobreNome { get; set; }
        public String telefone { get; set; }
        public Endereco endereco { get; set; }
        public int numPassagem { get; set; }
        public int numPoltrona { get; set; }

        public Pessoa(Endereco endereco, String nome, String cpf, String sobreNome, String telefone, int numPassagem,
            int numPoltrona) {
            this.endereco = endereco;
            this.nome = nome;
            this.sobreNome = sobreNome;
            this.telefone = telefone;
            this.cpf = cpf;
            this.numPassagem = numPassagem;
            this.numPoltrona = numPoltrona;
        
    }

        public override string ToString()
        {
            return "Cpf:" + this.cpf + "\nNome:" + this.nome + "\nNúmero da passagem:"+this.numPassagem
                +"\nPoltrona: " + this.numPoltrona +"\n";
        }



    }
}
