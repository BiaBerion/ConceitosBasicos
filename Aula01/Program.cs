using Aula01._1bim;
using System;
using System.Runtime.InteropServices;

public class Program
{

    public static void main()
    {

        bool continuar = true;
        int opcao;

        do
        {

            Console.WriteLine("[0] Sair\n\n[1]Somar dois números\n\n[2] Converter metros para mílimetros\n\n" +
                    "[3] Calcular aumento de sálario\n\n[4] Calcular desconto de um produto\n\n[5] Calcular o aluguel de um carro\n\n[6] Calcular seu IMC\n\n[7] Ver multiplos de 3\n\n\nOpção desejada : ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {

                case 0:

                    continuar = false;

                    break;

                case 1:

                    Soma();

                    break;

                case 2:

                    Conver();

                    break;

                case 3:

                    Aumento();

                    break;

                case 4:

                    Desconto();

                    break;

                case 5:

                    CalculoAluguel();

                    break;

                case 6:

                    Imc();

                    break;

                case 7:
                    Mult();

                    break;

                case 8:

                    Adivinha();

                    break;

                default:

                    Console.WriteLine("\n\nErro, tente novamente");

                    break;

            }

        } while (continuar == true);



        void Soma()
        {
            float num1, num2, res;

            Console.WriteLine("Digite um valor : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor : ");
            num2 = int.Parse(Console.ReadLine());

            SomaDoisNumeros soma = new SomaDoisNumeros();
            res = soma.Somar(num1, num2);

            Console.WriteLine($"A soma de {num1} e {num2} é {res}");

        }

        void Conver()
        {
            float num1, res;

            Console.WriteLine("Digite um comprimento em metros : ");
            num1 = int.Parse(Console.ReadLine());

            while (num1 < 0)
            {
                Console.WriteLine("\n\nValor inválido, tente novamenten\n\n");
                Console.WriteLine("Digite um comprimento em metros : ");
                num1 = int.Parse(Console.ReadLine());

            }

            ConverterMetroMilimetro conver = new ConverterMetroMilimetro();
            res = conver.Conver(num1);

            Console.WriteLine($"{num1} metros equivalem a {res} milímetros");

        }

        void Aumento()
        {

            Console.Write("Digite o salário atual: R$ ");
            double salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de aumento (%): ");
            double percentual = double.Parse(Console.ReadLine());

            CalculaAumento calc = new CalculaAumento();

            double aumento = calc.Aumento(salario, percentual);
            double novoSalario = calc.Calc(aumento, salario);

            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine($"Salário inicial: R$ {salario}");
            Console.WriteLine($"Percentual de aumento: {percentual}%");
            Console.WriteLine($"Valor do aumento: R$ {aumento}");
            Console.WriteLine($"Novo salário: R$ {novoSalario}");

        }

        void Desconto()
        {

            Console.Write("Digite o valor atual da mercadoria: R$ ");
            double valor = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de desconto (%): ");
            double descontoPercentual = double.Parse(Console.ReadLine());

            CalculaDesconto calc = new CalculaDesconto();

            double valorDesconto = calc.CalDescon(valor, descontoPercentual);
            double valorFinal = calc.CalResul(valor, valorDesconto);

            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine($"Valor atual: R$ {valor}");
            Console.WriteLine($"Percentual de desconto: {descontoPercentual}%");
            Console.WriteLine($"Valor do desconto: R$ {valorDesconto}");
            Console.WriteLine($"Valor final da mercadoria: R$ {valorFinal}");

        }

        void CalculoAluguel()
        {

            Console.Write("Digite o total de dias alugados: ");
            int dias = int.Parse(Console.ReadLine());

            Console.Write("Digite a quilometragem inicial: ");
            double kmInicial = double.Parse(Console.ReadLine());

            Console.Write("Digite a quilometragem final: ");
            double kmFinal = double.Parse(Console.ReadLine());

            CarroAluguel calc = new CarroAluguel();

            double kmRodados = calc.calcKm(kmInicial, kmFinal); 
            double valorTotal = calc.Aluguel(dias, kmRodados);

            Console.WriteLine("\n--- RESULTADO ---");
            Console.WriteLine($"Total de dias: {dias}");
            Console.WriteLine($"Quilometragem rodada: {kmRodados} km");
            Console.WriteLine($"Valor total a pagar: R$ {valorTotal}");

        }

        void Imc()
        {

            Console.Write("Digite seu peso (kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura (m): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite seu gênero (M/F): ");
            string genero = Console.ReadLine();
            while (genero != "M" || genero != "F")
            {

                Console.Write("Resposta invalida, tente novamente\n\n ");

                Console.Write("Digite seu gênero (M/F): ");
                genero = Console.ReadLine();

            }

            CalculoImc Calc = new CalculoImc();

            double imc = Calc.Imc(peso, altura);

            Console.WriteLine($"\nSeu IMC é: {imc:F2}\nSeu gênero é : {genero}");

            if (imc < 18.5)
            {
                Console.WriteLine("Classificação do IMC: Abaixo do peso");
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                Console.WriteLine("Classificação do IMC: Peso ideal (parabéns)");
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                Console.WriteLine("Classificação do IMC: Levemente acima do peso");
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                Console.WriteLine("Classificação do IMC: Obesidade grau I");
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                Console.WriteLine("Classificação do IMC: Obesidade grau II (severa)");
            }
            else
            {
                Console.WriteLine("Classificação do IMC: Obesidade III (mórbida)");
            }

        }

   
        void Mult()
        {
            Console.Write("Apresentando os multiplos de 3 entre 0 e 10:");

            Multiplos calc = new Multiplos();
        
        }
        void Adivinha() {

          
        }
    }
}
