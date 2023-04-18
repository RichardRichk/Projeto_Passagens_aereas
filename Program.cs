using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
//             Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair


// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).

            string[] nome = new string[2];
            string[] origem = new string[2];
            string[] destino = new string[2];
            string[] dataVoo = new string[2];

            string senha;
            char opcao;
            char resposta;

            static bool ValidacaoSenha(string senha){
                if (senha != "999")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

                Console.WriteLine($"Digite a senha:");
                senha = Console.ReadLine();
                while (ValidacaoSenha(senha))
                {
                    Console.WriteLine($"Senha incorreta, digite novamente!");
                    senha = Console.ReadLine();
                }
                Console.Clear();

            while (true)
            {
                Console.WriteLine("Digite a opção desejada:");
                Console.WriteLine("1- Cadastrar passagem");
                Console.WriteLine("2- Listar Passagens");
                Console.WriteLine("0- Sair");
                
                opcao = char.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                    do
                    {
                        for (var i = 0; i < 2; i++)
                        {
                        Console.WriteLine($"Qual o nome do passageiro {i+1} ?");
                        nome[i] = Console.ReadLine();
                        
                        Console.WriteLine($"Qual a origem do Voo {i+1} ?");
                        origem[i] = Console.ReadLine();
                        
                        Console.WriteLine($"Qual o destino do Voo {i+1} ?");
                        destino[i] = Console.ReadLine();

                        Console.WriteLine($"Qual a data do Voo {i+1} ? (DD/MM/AAAA)");
                        dataVoo[i] = Console.ReadLine();
                        }
                        Console.WriteLine($"Gostaria de cadastrar outra passagem ? S/N");
                        resposta = char.Parse(Console.ReadLine());
                        
                    } while (resposta == 's');

                        break;

                    case '2':
                    for (var i = 0; i < 2; i++)
                    {
                        Console.WriteLine(@$"
                        Nome: {nome[i]}
                        Origem: {origem[i]}
                        destino: {destino[i]}
                        data: {dataVoo[i]}
                        ");
                        
                    }
                        break;

                    case '0':
                    Console.WriteLine($"O programa sera encerrado...");
                    
                        return;

                    default:
                    Console.WriteLine($"Opcao invalida, Digite novamente!");
                    
                        break;
                }
                
            }



            
        }
    }
}
