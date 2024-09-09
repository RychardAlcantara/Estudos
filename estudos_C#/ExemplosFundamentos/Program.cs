// using Models.Pessoa;



List<string> lista = new List<string>();

lista.Add("SP");

lista.Add("RJ");

lista.Add("MG");

lista.Add("ES");

for(int i = 0; i < lista.Count; i++)
{
    Console.WriteLine($"Posição: {i} - {lista[i]}");
}

int contador = 0;
foreach(string a in lista) 
{
    Console.WriteLine($"Posição: {contador} - {a}");
    contador++;
}













// Console.WriteLine("Percorrendo o Array com o FOR");

// int[] array = new int[2];

// array[0] = 10;
// array[1] = 20;

// for (int i = 0; i < array.Length; i++) {
//     Console.WriteLine($"Posição: {i} - {array[i]}");
// }

// Array.Resize(ref array, array.Length * 2);

// Console.WriteLine("Percorrendo o Array com o FOREACH");

// int contador = 0;
// foreach (int item in array) {
//     Console.WriteLine($"Posição: {contador} - {item}");
//     contador++;
// }















//----------------------------------------------------------------
//CONVERSÃO DE STRING PARA NUMBER E DE NUMBER PARA STRING 
// int a = Convert.ToInt32("5"); 
// int c = int.Parse("5"); // a diferença entre o ToInt32 e Parse é o tratamento de valores nulos, 
// //se estiver nulo no parse ele vai dar errp e parar o programa já o toInt32 retornara o valor 0, portanto é mais aceitavel usar o Convert.ToInt32.

// string b = Convert.ToString(665456);
// int d = 262652165;
// string e = (65545).ToString();
// string f = d.ToString();

// Console.WriteLine(a);
// Console.WriteLine(b);
// Console.WriteLine(e);
// Console.WriteLine(f);
//----------------------------------------------------------------
//TRABALHANDO COM O TIPO DATE
// DateTime dataHoraAtual = DateTime.Now;
// string horaCompleta = DateTime.Now.ToString("HH:mm:ss");
// string dataAtual = DateTime.Now.ToString("dd/MM/yyyy");
// Console.WriteLine(dataHoraAtual);
// Console.WriteLine(horaCompleta);
// Console.WriteLine(dataAtual);

//----------------------------------------------------------------
//TIPOS DE VARIAVEIS
// string ap = "olaaaaaa";
// int quantity = 1;
// double price = 1.8000;
// decimal price1 = 10.0000M;

// Console.WriteLine(price1);
// Console.WriteLine(price);
// Console.WriteLine(ap);
// Console.WriteLine(quantity);

//----------------------------------------------------------------
//EXECUTANDO A CLASSE DENTRO DE using Models.Pessoa;
// Pessoa p = new Pessoa
// {
//     Nome = "John Doe",
//     Idade = 10
// };
// p.Apresentar();