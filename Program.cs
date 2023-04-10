namespace ContaCorrente
{
    internal class Program
    {
        public string numero;
        public int saldo;
        public bool contaEspecial;
        public int limite;
        public Movimentacao[] movimentacoes;
        public int valor;
        public string tipo;
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            conta1.numero = "1";
            conta1.saldo = 200;
            conta1.contaEspecial = true;
            conta1.limite = 300;
            conta1.movimentacoes = new Movimentacao[2];
            Movimentacao movimentacao1 = new Movimentacao();
            Movimentacao movimentacao2 = new Movimentacao();
            movimentacao1.propriedade = "260 Debito";
            movimentacao2.propriedade = "320 Credito";
            conta1.movimentacoes[0] = movimentacao1;
            conta1.movimentacoes[1] = movimentacao2;


            Conta conta2 = new Conta();
            conta2.numero = "2";
            conta2.saldo = 300;
            conta2.contaEspecial = false;
            conta2.limite = 600;
            conta2.movimentacoes = new Movimentacao[2];
            Movimentacao movimentacao3 = new Movimentacao();
            Movimentacao movimentacao4 = new Movimentacao();
            movimentacao3.propriedade = "500 Credito";
            movimentacao4.propriedade = "150 Debido";
            conta2.movimentacoes[0] = movimentacao3;
            conta2.movimentacoes[1] = movimentacao4;

            conta1.Sacar(100);
            conta1.Depositar(200);
            conta1.VisualizarSaldo();
            conta1.Transferir(150, conta2);
            conta2.VisualizarSaldo();
            Console.WriteLine();
            conta1.VisualizarExtrato(conta1.movimentacoes);
            Console.WriteLine();
            conta2.VisualizarExtrato(conta2.movimentacoes);
        }
    }
}