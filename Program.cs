using System.Runtime.InteropServices;

  //-----//
 //WHILE//
//-----//

// Console.WriteLine("Bem vindo(a) ao jogo da adivinha.");

// int numero = 15;
// repeat1:
// Console.Write("Adivinhe o número secreto: ");
// int resposta = int.Parse(Console.ReadLine());

// while(resposta != numero){
//     Console.WriteLine("Poxa.. você errou :( \nTente novamente: )");
//     goto repeat1;
// }

// Console.Clear();
// Console.WriteLine($"Parabéns, você acertou! \nO número secreto realmente era {numero}!! :)");

  //------//
 //MATRIZ//
//------//

Console.WriteLine("Matrizes => L,C ");

//declaração
string[,] Boletim;
//instanciação
Boletim = new string[5,5];

//linha 0
Boletim[0,0] = "Aluno";
Boletim[0,1] = "PORT";
Boletim[0,2] = "MAT";
Boletim[0,3] = "ART";
Boletim[0,4] = "EdF";
//linha 1
Boletim[1,0] = "5,0";
Boletim[1,1] = "8,0";
Boletim[1,2] = "7,5";
Boletim[1,3] = "9,5";
Boletim[1,4] = "7,0";
//linha 2
Boletim[2,0] = "5,0";
Boletim[2,1] = "9,0";
Boletim[2,2] = "8,0";
Boletim[2,3] = "7,0";
Boletim[2,4] = "10,0";
//linha 3
Boletim[3,0] = "4,5";
Boletim[3,1] = "3,0";
Boletim[3,2] = "9,0";
Boletim[3,3] = "10,0";
Boletim[3,4] = "10,0";
//linha 4
Boletim[4,0] = "5,0";
Boletim[4,1] = "2,8";
Boletim[4,2] = "4,2";
Boletim[4,3] = "9,2";
Boletim[4,4] = "3,3";

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"{Boletim[i,j]}\t");
    }
    Console.WriteLine();
}


//
Console.WriteLine("Pressione qualquer tecla para finalizar..");
Console.ReadKey();

