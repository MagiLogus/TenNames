// 6 - Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

string [] nomes = new string[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o nome da pessoa {i}");
    nomes[i] = Console.ReadLine();
}


Console.WriteLine($"Digite o nome que gostaria de buscar: ");
string buscar = Console.ReadLine();
    

bool achou = false;
for (int i = 0; i < 5; i++)
{
    if (buscar == nomes[i])
    {
        achou = true;
        break;
    }
}

if (achou)
{
    Console.WriteLine($"Você achou o nome!");
}
else
{
    Console.WriteLine($"Você não achou :(");
}