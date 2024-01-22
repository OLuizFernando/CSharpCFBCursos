using System;
class Aula06{

    static void Main(){

        string produto = "Pastel";
        double valorCompra = 5.50;
        double valorVenda;
        double lucro = 0.1;

        valorVenda = valorCompra + (valorCompra * lucro);

        Console.WriteLine("Produto:    {0,10}", produto);
        Console.WriteLine("Val. Compra:{0,10:c}", valorCompra);
        Console.WriteLine("Val. Venda: {0,10:c}", valorVenda);
        Console.WriteLine("Lucro:      {0,10:p}", lucro);

    }
}