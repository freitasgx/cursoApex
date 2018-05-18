using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuAplicativo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Exercício 01 - Página 75 Capítulo 12
             * Calcular consumo de energia 
             */
            /*
            float salarioMinimo, valorKW, consumo, valorAPagar, valorComDesconto;
            Console.WriteLine("Informe o valor do salário mínimo:");
            salarioMinimo = float.Parse(Console.ReadLine());

            valorKW = salarioMinimo / 7;

            Console.WriteLine("Informe o consumo da residência:");
            consumo = float.Parse(Console.ReadLine());

            valorAPagar = consumo * valorKW;
            valorComDesconto = valorAPagar - (valorAPagar / 10);

            Console.WriteLine(String.Format("Valor do KW {0}, total a pagar: {1} e valor com desconto {2}.", Math.Round(valorKW, 2), Math.Round(valorAPagar, 2), Math.Round(valorComDesconto, 2)));
            Console.ReadKey();
            */


            /*
             * Exercício 02 - Página 75 Capítulo 12
             * Calcular valor do desconto
             */
            /*
           float valorProduto = 0, percentualDesconto = 0, novoValor;
           while (valorProduto < 1)
           {
               Console.WriteLine("Informe o valor do produto:");
               valorProduto = float.Parse(Console.ReadLine());
               if(valorProduto < 1)
               {
                   Console.Clear();
                   Console.WriteLine("Informe um valor maior igual a 1!");
               }
           }
           while(percentualDesconto < 1 || percentualDesconto > 99) {
               Console.WriteLine("Informe o percentual de desconto");
               percentualDesconto = float.Parse(Console.ReadLine());
               if(percentualDesconto < 1 || percentualDesconto > 99)
               {
                   Console.Clear();
                   Console.WriteLine(String.Concat("Valor do produto: ", valorProduto));
                   Console.WriteLine("Insira um valor maior igual a 1 e menor que 100!");
               }
           }
           novoValor = valorProduto - ((valorProduto / 100) * percentualDesconto); 
           Console.WriteLine(String.Concat("O valor do produto com desconto ficou: ", novoValor ));
           Console.ReadKey();
           */


            /*
            * Exercício 03 - Página 75 Capítulo 12
            * Calcular Salário liquido
            */

            /*
            float valorAula = 0, numeroAula = 0, percentualINSS = 0, valorTotal;

            while (valorAula < 1)
            {
                Console.WriteLine("Informe o valor da aula:");
                valorAula = float.Parse(Console.ReadLine());
                if (valorAula < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Informe um valor maior igual a 1!");
                }
            }

            while (numeroAula < 1)
            {
                Console.WriteLine("Informe um numero de aulas:");
                numeroAula = float.Parse(Console.ReadLine());
                if (numeroAula < 1)
                {
                    Console.Clear();
                    Console.WriteLine(String.Concat("Valor da aula: ", valorAula));
                    Console.WriteLine("Informe o numero de aulas maior igual a 1!");
                }
            }

            while (percentualINSS < 1 || percentualINSS > 99)
            {
                Console.WriteLine("Informe o percentual de INSS");
                percentualINSS = float.Parse(Console.ReadLine());
                if (percentualINSS < 1 || percentualINSS > 99)
                {
                    Console.Clear();
                    Console.WriteLine(String.Concat("Valor da aula: ", valorAula));
                    Console.WriteLine(String.Concat("Numero de aulas: ", numeroAula));

                    Console.WriteLine("Insira um valor maior igual a 1 e menor que 100!");
                }
            }

            valorTotal = (valorAula * numeroAula);
            valorTotal -= ((valorTotal / 100) * percentualINSS);

            Console.WriteLine(String.Concat("O valor do salário liquido é de: ", valorTotal));
            Console.ReadKey();
            */
            /*
            * Exercício 04 - Página 76 Capítulo 12
            * Calcular gorjeta garçom
            */

            /*
            float valorDespesa = 0, gorjeta = 0;
            bool novaDespesa = true;
            string resposta;

            while (novaDespesa)
            {
                Console.WriteLine("Informe o valor da despesa:");
                valorDespesa += float.Parse(Console.ReadLine());
                Console.WriteLine("Deseja incluir uma nova despesa?");
                resposta = Console.ReadLine();
                novaDespesa = ( "sim".Equals(resposta.ToLower()) ? true : false);
            }
            gorjeta = (valorDespesa / 100) *10;
            Console.WriteLine("Valor da gorjeta: " + gorjeta);
            Console.ReadKey();
            */

            /*
            * Exercício 05 - Página 76 Capítulo 12
            * Calcular gorjeta garçom
            */

            /*
            double valorAplicacao, taxa, rendimento, numeroMeses;
            bool informarNovaAplicacao = true;
            string resposta;

            while (informarNovaAplicacao)
            {
                Console.WriteLine("Informe o valor da aplicação:");
                valorAplicacao = float.Parse(Console.ReadLine());

                Console.WriteLine("Informe a taxa a ser aplicada:");
                taxa = float.Parse(Console.ReadLine());

                Console.WriteLine("Informe o numero de meses:");
                numeroMeses = float.Parse(Console.ReadLine());


                rendimento = (valorAplicacao * (Math.Pow((1 + taxa), numeroMeses - 1)) / taxa);
                Console.WriteLine(String.Concat("Total do rendimento é de: ", rendimento));
                Console.WriteLine("===================================================");
                Console.WriteLine("Deseja informar uma nova aplicação? ");
                resposta = Console.ReadLine();
                informarNovaAplicacao = "sim".Equals(resposta.ToLower()) ? true : false;
            }
            */

            /*
            * Exercício 06 - Página 76 Capítulo 12
            * Validar se o numero é maior que 20
            */
            /*
            float numeroX;
            Console.WriteLine("Informe um numero:");
            numeroX = float.Parse(Console.ReadLine());
            
            if(numeroX > 20)
            {
                Console.WriteLine(numeroX);
                Console.ReadKey();
            }
            */

            /*
            * Exercício 07 - Página 76 Capítulo 12
            * Validar se o numero é maior que 10
            */
            /*
            float numeroX, numeroY;
            Console.WriteLine("Informe um numero:");
            numeroX = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro numero:");
            numeroY = float.Parse(Console.ReadLine());

            if ((numeroX+numeroY) > 10)
            {
                Console.WriteLine(numeroX + numeroY);
                Console.ReadKey();
            }
            */

            /*
            * Exercício 08 - Página 76 Capítulo 12
            * Validar se o numero é maior que 20 e subtrair ou adicionar
            */
            /*
            float numeroX, numeroY, result;
            Console.WriteLine("Informe um numero:");
            numeroX = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe outro numero:");
            numeroY = float.Parse(Console.ReadLine());

            result = numeroX + numeroY;
            if (result > 20)
            {
                result += 8;
                Console.WriteLine(String.Concat("Resultado é: ", result));
                Console.ReadKey();
            }
            else
            {
                result -= 5;
                Console.WriteLine(String.Concat("Resultado é: ", result));
                Console.ReadKey();
            }
            */

            /*
            * Exercício 09 - Página 76 Capítulo 12
            * Validar se o numero é maior que 20 e subtrair ou adicionar
            */
            /*
            float valorParcela, salario, limite;
            Console.WriteLine("Informe o valor da parcela:");
            valorParcela = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o salario bruto:");
            salario = float.Parse(Console.ReadLine());

            limite = (salario / 100) * 30;
            if (limite < valorParcela)
            {
                Console.WriteLine("Valor da parcela ultrapassa o limite de 30% do salário.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("O valor da parcela está dentro do limite de 30%, crédito pode ser concedido!");
                Console.ReadKey();
            }
            */

            /*
            * Exercício 10 - Página 76 Capítulo 12
            * Validar se o numero está entre 20 e 90
            */
            /*
            float numeroX;
            Console.WriteLine("Informe um numero:");
            numeroX = float.Parse(Console.ReadLine());

            if (numeroX >=20 && numeroX <= 90)
            {
                Console.WriteLine("Numero informado está entre 20 e 90");
            }
            else
            {
               Console.WriteLine("O número está fora do range de 20 a 90");
            }
            Console.ReadKey();
            */

            /*
            * Exercício 11 - Página 76 Capítulo 12
            * Validar se o numero está entre 20 e 90
            */

            /*
            float numeroX;
            Console.WriteLine("Informe um numero:");
            numeroX = float.Parse(Console.ReadLine());

            if (numeroX > 20)
            {
                Console.WriteLine("Numero informado é maior que 20");
            }
            else if(numeroX < 20)
            {
                Console.WriteLine("Numero informado é menor que 20");
            }
            else
            {
                Console.WriteLine("Numero informado é igual que 20");
            }
            Console.ReadKey();
            */
            /*
            * Exercício 12 - Página 76 Capítulo 12
            * Validar se o numero está entre 20 e 90
            */

            /*
            string nome, sexo;
            int idade;

            Console.WriteLine("Informe o nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Informe o sexo:");
            sexo = Console.ReadLine();

            Console.WriteLine("Informe a idade:");
            idade = int.Parse(Console.ReadLine());

            if("feminino".Equals(sexo.ToLower()) && idade < 25)
            {
                Console.WriteLine(String.Concat(nome, ", ACEITA"));
            }
            else
            {
                Console.WriteLine(String.Concat(nome, ", NÃO ACEITA"));
            }
            Console.ReadKey();
            */
            /*
            * Exercício 13 - Página 77 Capítulo 12
            * Validar se o numero está entre 20 e 90
            */
            string uF;

            Console.WriteLine("Informe a unidade federativa (Sigla):");
            uF = Console.ReadLine();

            switch (uF.ToLower())
            {
                case "rj":
                    Console.WriteLine("Carioca");
                    break;
                case "sp":
                    Console.WriteLine("Paulista");
                    break;
                case "mg":
                    Console.WriteLine("Mineiro");
                    break;
                default:
                    Console.WriteLine("Outros estados");
                    break;
            }
            Console.ReadKey();
        }
    }
}
