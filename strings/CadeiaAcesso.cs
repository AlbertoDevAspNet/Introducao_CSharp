using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introducao_CSharp.strings
{
    public class CadeiaAcesso
    {
        string nome = "Alberto";
        public void acessar()
        {
            Console.WriteLine(nome.Length);
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.ToLower());
            Console.WriteLine(nome.Contains("Alberto"));
            Console.WriteLine(nome[2]);
        }
    }
}