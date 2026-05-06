using Introducao_CSharp.concatenacao;
using Introducao_CSharp.strings;
using Introducao_CSharp.strings.interpolacao;
using Introducao_CSharp.strings.objetos;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Concatenar concatenar = new Concatenar();
        //concatenar.concatenar(" ", " "); 

        // Chamando metodo da Classe Interpolar 
        Interpolar interpolar = new Interpolar();
        //interpolar.interpolar();

        //Chamando metodo da Classe CadeiaAcesso
        Console.WriteLine("Acessando os metodos da classe CadeiaAcesso: ");
        CadeiaAcesso cadeiaAcesso = new CadeiaAcesso();
        //cadeiaAcesso.acessar();
        /*Carro carro = new Carro();
        carro.modelo = "Civic";
        carro.marca = "Honda";
        carro.preco = 100000.00;
        carro.cor = "Preto";
        Console.WriteLine($"Modelo: {carro.modelo}, Marca: {carro.marca}, Preço: {carro.preco}, Cor: {carro.cor}");*/

        
        /*Carro carro2 = new Carro();
        carro2.modelo = "Corolla";
        carro2.marca = "Toyota";
        carro2.preco = 90000.00;
        carro2.cor = "Branco";
        Console.WriteLine($"Modelo: {carro2.modelo}, Marca: {carro2.marca}, Preço: {carro2.preco}, Cor: {carro2.cor}");
        */
    }
}