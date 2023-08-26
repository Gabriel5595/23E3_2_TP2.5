using System;

class Pedido
{  
    private const double valorHamburguer = 30.0;
    private const double valorBatataFrita = 12.0;
    private const double valorRefrigerante = 8.0;

    public int numeroPedido { get; }
    public int QuantHamburguer { get; private set; }
    public int QuantBatataFrita { get; private set; }
    public int QuantRefrigerante { get; private set; }

    public Pedido()
    {
        Random random = new Random();
        numeroPedido = random.Next(1000, 10000);
    }

    public void AdicionaHamburguer()
    {
        QuantHamburguer ++;
    }

    public void AdicionaBatataFrita()
    {
        QuantBatataFrita ++;
    }

    public void AdicionaRefrigerante()
    {
        QuantRefrigerante ++;
    }

    public double calcularTotalPedido()
    {
        double total = (QuantHamburguer * valorHamburguer) + (QuantBatataFrita * valorBatataFrita) + (QuantRefrigerante * valorRefrigerante);
        if (total > 100)
        {
            double desconto = total * 0.1;
            total -= desconto;
        }
        return total;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pedido pedido = new Pedido();

        while (true)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1. Adicionar um item ao pedido.");
            Console.WriteLine("2. Mostrar os itens e o valor total a pagar.");
            Console.WriteLine("3. Sair do programa.");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            if (opcao == 1)
            {
                Console.WriteLine("Selecione um item:");
                Console.WriteLine("1. Adicionar Hambúrguer");
                Console.WriteLine("2. Adicionar Batata Frita");
                Console.WriteLine("3. Adicionar Refrigerante");
                int itemSelecionado = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                switch (itemSelecionado)
                {
                    case 1:
                        pedido.AdicionaHamburguer();
                        Console.WriteLine("Hambúrguer adicionado ao pedido.");
                        Console.WriteLine("");
                        break;
                    case 2:
                        pedido.AdicionaBatataFrita();
                        Console.WriteLine("Batata Frita adicionada ao seu pedido");
                        Console.WriteLine("");
                        break;
                    case 3:
                        pedido.AdicionaRefrigerante();
                        Console.WriteLine("Refrigerante adicioando ao pedido");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        break;
                }
            }
            else if (opcao == 2)
            {
                Console.WriteLine($"Itens no pedido:");
                Console.WriteLine($"Hambúrguer: {pedido.QuantHamburguer}");
                Console.WriteLine($"Batata Frita: {pedido.QuantBatataFrita}");
                Console.WriteLine($"Refrigerante: {pedido.QuantRefrigerante}");

                double total = pedido.calcularTotalPedido();
                Console.WriteLine($"Total a pagar: {total:c}");
                Console.WriteLine("");
            }
            else if (opcao == 3)
            {
                Console.WriteLine("Encerrando o programa. Obrigado!");
                Console.WriteLine("");
                break;
            }
            else
            {
                Console.WriteLine("Opção Inválida");
                Console.WriteLine("");
            }
        }
    }
}