public class Estoque{


    Games[] games = new Games[0];

    public void Adicionar (Games game)
    {
        Games[] novoVetor = new Games[games.Length + 1];
        for (int pos = 0; pos <games.Length; pos++)
        {
            Games item = games[pos];
            novoVetor[pos] = item;
        }

        novoVetor[novoVetor.Length - 1] = game;
        games = novoVetor;
    }

    public void Remover (int pos)
    {
        if (pos >= 1 && pos <= games.Length)
    {
        Games[] novoVetor = new Games[games.Length - 1];
        int novoIndex = 0;
        for (int i = 0; i < games.Length; i++)
        {
            if (i != pos - 1)
            {
                novoVetor[novoIndex] = games[i];
                novoIndex++;
            }
        }
        games = novoVetor;
    }
    else
    {
        Console.WriteLine("Posição inválida.");
    }
   
    }

    public void Listar()
    {   
        int cont =1; 
        foreach(Games item in games)
        {
            Console.WriteLine($"{cont}. Jogo: {item.Nome} - Ano: {item.Ano}- Valor: {item.Preco} - Gênero: {item.Genero} - Desenvolvedor: {item.Desenvolvedor} - Estoque: {item.Estoque}");
            cont++;
        }
    }

    public void Entrada(int pos, int qtd)
    {
      Games game = games[pos -1]; 
      game.Estoque += qtd;  

    }

    public void Saida(int pos, int qtd)
    {
      Games game = games[pos -1]; 
      game.Estoque -= qtd;  

    } 

}


