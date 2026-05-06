using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introducao_CSharp.concatenacao
{
    public class Concatenar
    {
      // string nome = "João";
       //string sobreNome = "Silva";

       //string nomeCompleto = nome + "" + sobreNome;
      // console.WriteLine(nomeCompleto);

       public void concatenar(string nome, string sobreNome)
        {
             Console.WriteLine("Digite seu nome: ");    
             nome = Console.ReadLine();
             Console.WriteLine("Digite seu sobrenome: ");
             sobreNome = Console.ReadLine();
                string nomeCompleto = nome + " " + sobreNome;
                //Console.WriteLine("Seu nome completo é: " + nomeCompleto);
                //ou posso exibir sobreNome e nome usando Metodo 
                //Concat
                string nomeCompleto2 = string.Concat(nome, " ", sobreNome);
                Console.WriteLine("Seu nome completo é: " + nomeCompleto2);
        }



    }
}