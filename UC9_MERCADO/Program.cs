// Variáveis
string[,] matriz = new string[6, 4];
int l = 0;
int c = 0;
string mercado = "";
double total;
total = 0;
int respostas;
int codigo;
string continuar = "S";

//Cadastrar Produtos
for (l = 0; l <= 5; l++)
{
    for (c = 0; c <= 3; c++)
    {
        if (c == 0)
        {
            mercado = "Descrição:";
        }
        if (c == 1)
        {
            mercado = "Tipo:";
        }
        if (c == 2)
        {
            mercado = "Cor:";
        }
        if (c == 3)
        {
            mercado = "Preço:";
        }
        Console.WriteLine(mercado);
        matriz[l, c] = Console.ReadLine();
    }
}

while (continuar == "S" || continuar == "s") {
    Console.Clear();

    // Lista de Produtos
    for (l = 0; l <= 5; l++)
    {
        for (c = 0; c <= 3; c++)
        {
            Console.Write(matriz[l, c] + " - ");
        }
        Console.WriteLine("");
    }

    Console.WriteLine();
    Console.WriteLine("|               'ESCOLHA SEUS PRODUTOS!'                 |");
    Console.WriteLine("*========================================================*");
    Console.WriteLine();
    Console.WriteLine("|           Mercado 1: " + matriz[0, 0] + " Digite 1           |");
    Console.WriteLine("|           Mercado 2: " + matriz[1, 0] + " Digite 2           |");
    Console.WriteLine("|           Mercado 3: " + matriz[2, 0] + " Digite 3           |");
    Console.WriteLine("|           Mercado 4: " + matriz[3, 0] + " Digite 4           |");
    Console.WriteLine("|           Mercado 5: " + matriz[4, 0] + " Digite 5           |");
    Console.WriteLine("|           Mercado 6: " + matriz[5, 0] + " Digite 6           |");
    Console.WriteLine();

    // EScolher Produtos Listados
    Console.WriteLine("Escolha seus produtos: ");
    respostas = int.Parse(Console.ReadLine());

    // Totalizar a Venda
    total = total + double.Parse(respostas[, 3]);
    Console.WriteLine("O total da sua compra foi: " + total);

    Console.WriteLine("Deseja continuar outro produto? S / N ");
    continuar = Console.ReadLine();
}