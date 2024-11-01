ExibirTitulo();
 
Console.Write("informe um número: ");
int numero = Convert.ToInt32(Console.ReadLine());
 
bool ehPar = DefinirPar (numero);
 
 
void ExibirTitulo()
{ 
Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("--------------------");
Console.WriteLine("--- Par ou Impar ---");
Console.WriteLine("--------------------\n");
Console.ResetColor();
}
 
bool DefinirPar(int numero)
{
bool ehPar = numero % 2 == 0;
return ehPar;
}
 
ExibirResultado();
 
void ExibirResultado()
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"O número {numero} é {(ehPar ? "Par" : "impar")}");
Console.WriteLine("-----------------");
Console.WriteLine("--- Resultado ---");
Console.WriteLine("------------------\n");
Console.ResetColor();
}
tem menu de contexto
