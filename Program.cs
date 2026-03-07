using System;
using System.Collections.Generic;
using PrimeiroProjeto.Entity;
class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> pessoa = new List<Pessoa>();
        PessoaFisica pf = new PessoaFisica();
        pf.nome = "Gustavo";
        pf.idade = 18;
        pf.cpf = 123456789;
        pessoa.Add(pf);
        PessoaJuridica pj = new PessoaJuridica();
        pj.nome = "Calmamente";
        pj.cnpj = "123456789/0001-00";
        pj.idade = 5;
        pessoa.Add(pj);

       foreach (Pessoa p in pessoa)
       {
                p.ExibirDados();
            
       }
    }
}