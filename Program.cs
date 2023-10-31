
// Array com Números

int[] arrayInteiros = new int[3];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;

int[] arrayInteirosDobrado = new int[arrayInteiros.Length *2]; 
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);  // Vai aumentar o array e vai copiar do outro array

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); // Para aumentar o número de array

//Percorrendo o Array com FOR
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N: {contador} - {arrayInteiros[contador]}");
}

//Percorrendo o Array com FOREACH
foreach (int valor in arrayInteiros)
{
    Console.WriteLine(valor);
}



// Lista com String

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("DF");
listaString.Add("BA");
listaString.Add("MG");
listaString.Add("GO");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - capacidade: {listaString.Capacity}");
listaString.Add("SC");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - capacidade: {listaString.Capacity}");
listaString.Remove("MG");

Console.WriteLine($"Itens na minha lista: {listaString.Count} - capacidade: {listaString.Capacity}");

for(int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição N: {contador} - {listaString[contador]}"); 
}



Console.WriteLine("Percorrendo o Lista com FOREACH");
int contadorForeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição N: {contadorForeach} - {item}");
    contadorForeach++;
}