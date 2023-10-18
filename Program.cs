using System.Diagnostics.Contracts;

var nomeProduto = new List<string> {"Leite","Macarrão"};
var codigoBarras = new List<int> {123,456};
var quantidadeProduto = new List<int> {5,8};
var precoProduto = new List<double> {2.80,5.50};
var dataVencimento = new List<string>{"18/07/2023","10/12/2024"};

for(int i = 1; i <= 3; i++)
{
    Console.WriteLine("1 - Adicionar novo produto em estoque \n2 - Remover produto já existente \n3 - Atualizar produto já existente \n4 - Buscar produto \n5 - Calcule o valor total do estoque \n6 - Gerar relatório dos produtos prestes a vencer \n7 - Sair do programa");
    int choose = Convert.ToInt16(Console.ReadLine());
    switch(choose)
    {
        case 1:

            i = 0;
            Console.WriteLine("--- Cadastrar novo produto --- \nNome do produto:");
            nomeProduto.Add(Console.ReadLine());
            Console.WriteLine("Código de barras:");
            codigoBarras.Add(Convert.ToInt16(Console.ReadLine()));
            Console.WriteLine("Quantidade do produto:");
            quantidadeProduto.Add(Convert.ToInt16(Console.ReadLine()));
            Console.WriteLine("Preço unitário:");
            precoProduto.Add(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Data de vencimento:");
            dataVencimento.Add(Console.ReadLine());

        break;
        case 2:
        
            Console.WriteLine("--- Remover produto ---");
            Console.WriteLine("Digite o código de barras do produto:");
            int removeInput = Convert.ToInt32(Console.ReadLine());

            var indexRemove = codigoBarras.IndexOf(removeInput);

            if(indexRemove == -1)
            {
                Console.WriteLine("Produto não encontrado... Tente novamente!");
            }
            else
            {
                nomeProduto.RemoveAt(indexRemove);
                codigoBarras.RemoveAt(indexRemove);
                quantidadeProduto.RemoveAt(indexRemove);
                precoProduto.RemoveAt(indexRemove);
                dataVencimento.RemoveAt(indexRemove);

                if(codigoBarras.IndexOf(removeInput) == -1)
                    Console.WriteLine("Produto removido com sucesso.");
                else
                    Console.WriteLine("Algo deu errado tente novamente.");

                Console.ReadLine();
            }
        break;
        case 3:

            Console.WriteLine("--- Atualizar produto ---");

            Console.WriteLine("Digite o código de barras do produto:");
            int updateInput = Convert.ToInt32(Console.ReadLine());
            var indexUpdate = codigoBarras.IndexOf(updateInput);

            if(indexUpdate == -1)
            {
                Console.WriteLine("Produto não encontrado... Tente novamente!");
            }
            else
            {
                Console.WriteLine("Qual campo você gostaria de alterar? \n1 - Nome do produto \n2 - Código de barras \n3 - Quantidade do produto \n4 - Preço do produto (Unitário) \n5 - Data de vencimento");
                int chooseUpdate = Convert.ToInt16(Console.ReadLine());

                switch(chooseUpdate)
                {
                    case 1:
                        Console.WriteLine("Digite o novo nome do produto:");
                        string nomeUpdate = Console.ReadLine();
                        nomeProduto.Insert(indexUpdate,nomeUpdate);
                    break;
                    case 2:
                        Console.WriteLine("Digite a nova quantidade de produtos:");
                        int quantidadeUpdate = Convert.ToInt32(Console.ReadLine());
                        quantidadeProduto.Insert(indexUpdate,quantidadeUpdate);
                    break;
                    case 3:
                        Console.WriteLine("Digite o novo código de barras do produto:");
                        int codigoBarrasUpdate = Convert.ToInt32(Console.ReadLine());
                        codigoBarras.Insert(indexUpdate,codigoBarrasUpdate);
                    break;
                    case 4:
                        Console.WriteLine("Digite o valor do produto:");
                        double precoUpdate = Convert.ToDouble(Console.ReadLine());
                        precoProduto.Insert(indexUpdate,precoUpdate);

                    break;
                    case 5:
                        Console.WriteLine("Digite a nova data de vencimento:");
                        string datavencimentoUpdate = Console.ReadLine();
                        dataVencimento.Insert(indexUpdate,datavencimentoUpdate);
                    break;
                    default:
                        Console.WriteLine("Algo deu errado... Tente novamente.");
                        Console.ReadLine();
                    break;
                }
                Console.WriteLine("\nDado atualizado com sucesso!");
                Console.WriteLine("Nome: {0} \nCódigo de Barras: {1} \nQuantidade: {2} \nPreço unitário: {3} \nData de vencimento: {4}",nomeProduto[indexUpdate],codigoBarras[indexUpdate],quantidadeProduto[indexUpdate],precoProduto[indexUpdate],dataVencimento[indexUpdate]);
                Console.ReadLine();
            }

        break;
        case 4:

            Console.WriteLine("--- Buscar produto ---");

            Console.WriteLine("Digite o código de barras do produto:");
            int searchInput = Convert.ToInt32(Console.ReadLine());
            var indexSearch = codigoBarras.IndexOf(searchInput);

            if(indexSearch == -1)
            {
                Console.WriteLine("Produto não encontrado... Tente novamente!");
            }
            else
            {
            Console.WriteLine("Nome: {0} \nCódigo de Barras: {1} \nQuantidade: {2} \nPreço unitário: {3} \nData de vencimento: {4}",nomeProduto[indexSearch],codigoBarras[indexSearch],quantidadeProduto[indexSearch],precoProduto[indexSearch],dataVencimento[indexSearch]);
            Console.ReadLine();
            }

        break;
        case 5:

            Console.WriteLine("--- Valor total do estoque ---");   
            double valorEstoque = 0;

             for(int v = 0; v < precoProduto.Count;v++)
            {
                valorEstoque += precoProduto[v];
            }

            Console.WriteLine("O valor total do estoque é de R$"+valorEstoque);
            Console.ReadLine();

        break;
        case 6:

            Console.WriteLine("--- Relatório dos produtos prestes a vencer ---");

        break;
        case 7:
            Console.WriteLine("Você escolheu sair...");
            i = 3;
            Console.ReadLine();
        break;
        default:
        Console.WriteLine("\nEscolha incorreta tente novamente.\nApós 3 tentativas o programa será encerrado. \nTentativa número : {0}",i);
        break;
    }
}

