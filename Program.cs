
using PrimeiroProjeto.Model;
using PrimeiroProjeto.Services;

Pessoa pessoa = new Pessoa();
pessoa.nome = "Gustavo";
pessoa.salario = 1090;

DespessasService service = new DespessasService(pessoa);
service.AdicionarDespesa(new Despessas
{
    descricao = "Investimento",
    valor = 600
});
service.AdicionarDespesa(new Despessas
{
    descricao = "Gastos",
    valor = 200
});
service.CalcularTotalDespesa();