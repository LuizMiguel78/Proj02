using banco;

internal class Program
{
    private static void Main(string[] args)
    {
        Banco meuBanco = new Banco();
        meuBanco.nome = "Banco Genérico";
        meuBanco.codigoBACEN = "000";

        ContaBancaria contaOrigem = new ContaBancaria();
        contaOrigem.agencia = "0001";
        contaOrigem.numeroConta = "123456-7";

        ContaBancaria contaDestino = new ContaBancaria();
        contaDestino.agencia = "0002";
        contaDestino.numeroConta = "765432-1";

        Transacao minhaTransacao = new Transacao();
        minhaTransacao.contaOrigem = contaOrigem;
        minhaTransacao.contaDestino = contaDestino;
        minhaTransacao.valor = 123.45m;
        minhaTransacao.data = DateTime.Now;
        minhaTransacao.tipo = "Pix";

        Console.WriteLine($"Banco: {meuBanco.nome}\nCódigo BACEN: {meuBanco.codigoBACEN}");
        Console.WriteLine($"Conta Origem: {contaOrigem.numeroConta} - Agência: {contaOrigem.agencia}");
        Console.WriteLine($"Conta Destino: {contaDestino.numeroConta} - Agência: {contaDestino.agencia}");
        Console.WriteLine($"Valor: {minhaTransacao.valor}\nData: {minhaTransacao.data}\nTipo: {minhaTransacao.tipo}");
    }
}
