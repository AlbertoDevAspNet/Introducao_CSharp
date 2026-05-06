using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introducao_CSharp.Estruturas.Switch_Case
{
    public class CondicaoSwit
    {
        string diaSemana= "Segunda-feira";
        public void testar()
        {
            switch (diaSemana)
            {
                case "Segunda-feira":
                    Console.WriteLine("Hoje é Segunda-feira");
                    break;
                case "Terça-feira":
                    Console.WriteLine("Hoje é Terça-feira");
                    break;
                case "Quarta-feira":
                    Console.WriteLine("Hoje é Quarta-feira");
                    break;
                case "Quinta-feira":
                    Console.WriteLine("Hoje é Quinta-feira");
                    break;
                case "Sexta-feira":
                    Console.WriteLine("Hoje é Sexta-feira");
                    break;
                case "Sábado":
                    Console.WriteLine("Hoje é Sábado");
                    break;
                case "Domingo":
                    Console.WriteLine("Hoje é Domingo");
                    break;
                default:
                    Console.WriteLine("Dia da semana inválido");
                    break;
            }
        } 
    }
}