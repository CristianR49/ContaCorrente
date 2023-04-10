using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente
{
    public class Conta
    {
        public string numero;
        public int saldo;
        public bool contaEspecial;
        public int limite;
        public Movimentacao[] movimentacoes;

        public void Sacar(int saque)
        {
            if (saque > limite + saldo)
            {
                Console.WriteLine("Valor inválido");
            }
            else
            {
                saldo -= saque;
            }
        }
        public void Depositar(int deposito)
        {
            saldo += deposito;
        }
        public void VisualizarSaldo()
        {
            Console.WriteLine($"Saldo Conta{numero}:{saldo}");
        }
        public void VisualizarExtrato(Movimentacao[] movimentacao)
        {
            Console.WriteLine($"Extrato Conta{numero}:");
            Console.WriteLine("Valor".PadRight(50, ' ') + "| " + "Tipo");
            Console.WriteLine("-".PadRight(100, '-'));
            foreach (Movimentacao movimentacaoOBJ in movimentacao)
            {
                Console.WriteLine(movimentacaoOBJ.valor.PadRight(50, ' ') + "| " + movimentacaoOBJ.tipo);
            }
            
        }
        public void Transferir(int valor, Conta conta)
        {
            saldo += valor;
            conta.saldo -= valor;
        }
    }
}
