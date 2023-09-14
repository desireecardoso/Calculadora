using System;
namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+': operacao.resultado= soma(operacao);break;
                case '-': operacao.resultado = subtracao(operacao);break;
                case '*': operacao.resultado = multiplicacao(operacao);break;
                //Inclusão da Operação de Divisão
                case '/': operacao.resultado = divisao(operacao);break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        //Alterado de int para long
        public long soma(Operacoes operacao)
        {
            return operacao.valorA + operacao.valorB;
        }
        //Alterado de int para long
        public long subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        //Alterado de int para long
        public long multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        //Inclusão da Operação de Divisão
        public long divisao(Operacoes operacao)
        {
            return operacao.valorA / operacao.valorB;
        }
        
       
    }
}
