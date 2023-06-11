Console.Clear();

Console.WriteLine("--- Entrada Válida ---");

int numero = -1;

while (numero < 0 || numero >9)
{
    Console.WriteLine("Digite um número entre 1 e 9 (ou 0 para cancelar)...:");
    numero = Convert.ToInt32(Console.ReadLine()!.Trim());
}

if (numero == 0)
{
    Console.WriteLine("Operação Cancelada.");
    Console.WriteLine("Volte Sempre!");
}
else
{
    Console.WriteLine($"Numero Selecionado: {numero}");
}
