using RefatorarObserver.Models;

Console.WriteLine(" Aumentar Preço ");

//Simulando dados do Banco
List<Produto> produtos = new List<Produto>(){
    new Produto(1,"Banana",10.00m),
    new Produto(2,"Maçã",20.00m),
    new Produto(3,"Uva",40.00m)
};

Console.WriteLine($"Valor em Estoque Antes do aumento: {produtos.Sum(x =>x.Preco)}");

//Fazer Inscrição
AumentarPreco atualizarPreco = new AumentarPreco();
foreach (var produto in produtos)
{
    atualizarPreco.add(produto);
}

//Aumentar
atualizarPreco.AplicarAumento(10m);

Console.WriteLine($"Valor em Estoque Depois do aumento: {produtos.Sum(x => x.Preco)}");