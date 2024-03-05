namespace project_games;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("CONTROLE DE ESTOQUE - LOJA VN-GAMES"); 
        Estoque estoque = new Estoque();
        int menu = 0; 
        do {
        Console.WriteLine();
        Console.WriteLine("Digite um comando: ");
        Console.WriteLine();
        Console.WriteLine("[1] Novo");
        Console.WriteLine("[2] Listar Produtos");
        Console.WriteLine("[3] Remover Produtos");
        Console.WriteLine("[4] Entrada de Estoque");
        Console.WriteLine("[5] Saída de Estoque");
        Console.WriteLine("[0] Sair");
        menu = Convert.ToInt32(Console.ReadLine());
        
        if (menu == 1)
        {
            Games novoGame = new Games();
            Console.WriteLine();
            Console.WriteLine("Nome do jogo: ");
            novoGame.Nome = Console.ReadLine();
            Console.WriteLine("Preço: "); 
            novoGame.Preco = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Desenvolvedor: ");
            novoGame.Desenvolvedor = Console.ReadLine();
            Console.WriteLine("Gênero: "); 
            novoGame.Genero = Console.ReadLine();
            Console.WriteLine("Ano: "); 
            novoGame.Ano = Convert.ToInt32(Console.ReadLine());
            estoque.Adicionar(novoGame);
        }


        else if (menu == 2 )
        {
            Console.WriteLine("\nItens no estoque: ");
            estoque.Listar();
    
        }
        else if (menu == 3 )
        {
           Games removeGame = new Games();
           Console.WriteLine();

           Console.WriteLine("\nItens no estoque: ");
           estoque.Listar();

           Console.WriteLine("Posição do jogo para remover: "); 
           int pos = Convert.ToInt32(Console.ReadLine()); 
           Console.WriteLine(); 
           estoque.Remover(pos); 

        }
        else if (menu == 4 )
        {
            Console.WriteLine("\nItens no estoque: ");
            estoque.Listar();
            Console.WriteLine("Posição do jogo: "); 
            int pos = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine();
            Console.WriteLine("Quantidade de entrada: "); 
            int qtd = Convert.ToInt32(Console.ReadLine()); 
            estoque.Entrada(pos, qtd);
        }
        else if (menu == 5 )
        {
            Console.WriteLine("\nItens no estoque: ");
            estoque.Listar();
            Console.WriteLine();
            Console.WriteLine("Posição do jogo: "); 
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); 
            Console.WriteLine("Quantidade de saída: "); 
            int qtd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(); 
            estoque.Saida(pos, qtd);
        }
        }
        while (menu != 0);
        {
            Console.WriteLine();
            Console.WriteLine("Obrigado, até a próxima.");
        }
    }
}


// VINICIUS ALVES SILVA
// 2º SEMESTRE 
// SISTEMAS PARA INTERNET 
// DISCIPLINA: ALGORITMOS E PROGRAMAÇÃO II. 



