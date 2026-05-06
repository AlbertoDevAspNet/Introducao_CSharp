using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introducao_CSharp.strings.interpolacao
{
    public class Interpolar
    {
        string nome= "Thiago";
        string sobreNome = "Silva";
        //string nomeCompleto = $"Meu nome é {nome} {sobreNome}";
        //Console.WriteLine(nomeCompleto);
        public void interpolar()
        {
            string nomeCompleto = $"Meu nome é {nome} {sobreNome}";
            Console.WriteLine(nomeCompleto);
        }
    }
}