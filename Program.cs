using System.Runtime.InteropServices;

Console.WriteLine("Listas");
List<string> nomes = new List<string>();
// // Add nomes na lista
// nomes.Add("Ju");
// nomes.Add("Su");
// nomes.Add("Fu");
// nomes.Add("Hu");
// nomes.Add("Au");

// //remov nomes da lista
// nomes.Remove("Su");

// //Acessando pelo índice
// Console.WriteLine(nomes.ElementAt(2));

// //Saída
// nomes.ForEach(Console.WriteLine);

// //Contando qtd elementos
// Console.WriteLine(nomes.Count());

List<int> ListaNum = new List<int>{10, 20, 30, 40, 100};
ListaNum.RemoveAt(1);
ListaNum.ForEach(Console.WriteLine);



//
Console.WriteLine("Pressione qualquer tecla para finalizar..");
Console.ReadKey();

