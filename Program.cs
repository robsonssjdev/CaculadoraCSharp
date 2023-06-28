Menu();
static void Menu()
{
  Console.Clear();
  Console.WriteLine("O que deseja fazer?");
  Console.WriteLine("");

  Console.WriteLine("1 - Soma");
  Console.WriteLine("2 - Subtração");
  Console.WriteLine("3 - Divisão");
  Console.WriteLine("4 - Multiplicação");

  Console.WriteLine("Selecione uma opção:");
  short opcao = short.Parse(Console.ReadLine());

  switch (opcao)
  {
    case 1:
      Soma();
      break;
    case 2:
      Subtracao();
      break;
    case 3:
      Divisao();
      break;
    case 4:
      Multiplicacao();
      break;
    default:
      Console.WriteLine("Digite uma opção valida");
      break;
  }
}
static void Soma()
{
  Console.Clear();
  Console.WriteLine("Digite o primeiro valor: ");
  float valor1 = float.Parse(Console.ReadLine());
  Console.WriteLine("Digite o segundo valor: ");
  float valor2 = float.Parse(Console.ReadLine());
  Console.WriteLine("");
  Console.WriteLine($"O resultado da soma é: {valor1 + valor2}");
  Console.ReadKey();
}

static void Subtracao()
{
  Console.Clear();
  Console.WriteLine("Digite o primeiro valor: ");
  float valor1 = float.Parse(Console.ReadLine());
  Console.WriteLine("Digite o segundo valor: ");
  float valor2 = float.Parse(Console.ReadLine());
  Console.WriteLine("");
  Console.WriteLine($"O resultado da subtração é: {valor1 - valor2}");
  Console.ReadKey();
}
static void Divisao()
{
  Console.Clear();
  Console.WriteLine("Digite o primeiro valor: ");
  float valor1 = float.Parse(Console.ReadLine());
  Console.WriteLine("Digite o segundo valor: ");
  float valor2 = float.Parse(Console.ReadLine());
  Console.WriteLine("");
  Console.WriteLine($"O resultado da Divisão é: {valor1 / valor2}");
  Console.ReadKey();
}
static void Multiplicacao()
{
  Console.Clear();
  Console.WriteLine("Digite o primeiro valor: ");
  float valor1 = float.Parse(Console.ReadLine());
  Console.WriteLine("Digite o segundo valor: ");
  float valor2 = float.Parse(Console.ReadLine());
  Console.WriteLine("");
  Console.WriteLine($"O resultado da Multiplicacao é: {valor1 * valor2}");
  Console.ReadKey();
}