using System;
using System.Collections;
using System.Collections.Generic;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' }); //Implemente o calculo de divisao

            Calculadora calculadora = new Calculadora();
            //Inclusão da Pilha
            Stack pilha = new Stack();

            //Alterado de >= 0 para > 0, para que não pegue uma fila vazia
            while (filaOperacoes.Count > 0)
            {
                //Alterado de Peek para Dequeue, pois o Peek apenas pega o elemento sem remover da fila, enquanto o Dequeue pega o elemento e também o remove da fila
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);

                Console.WriteLine("Operação Realizada:");
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);

                //Imprime lista de operações a serem realizadas após cada cálculo
                if (filaOperacoes.Count > 1) {
                    Console.WriteLine("Resta Calcular:");
                    foreach (var fila_restante in filaOperacoes)
                    {
                        Console.WriteLine("{0} {1} {2}", fila_restante.valorA, fila_restante.operador, fila_restante.valorB);
                    }
                }

                //Acrescenta resultados na pilha
                pilha.Push(operacao.resultado);

            }
            //Imprime os resultados contidos dentro da Pilha
            Console.WriteLine("Pilha de Resultados Obtidos:");
            foreach (var resultado in pilha){
                Console.WriteLine(resultado);
            }

            //Para visualização
            Console.ReadLine();          
           
        }
    }
}
