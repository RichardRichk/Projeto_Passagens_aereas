using System;

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

            static bool Login(string senha){
                if (senha != "999")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            // static void UseParams(params string[] Passagens)
            // {
            //     for (int i = 0; i < Passagens.Length; i++)
            //     {
            //         Passagens[i] = 
            //         @$"nome:" {nome};
            //         "origem:" {origem};
            //         "destino:" {destino};
            //         "data do voo:" {datadoVoo};
            //     }
            // }

            static string CadastroPassagens(){

                Console.WriteLine($"Qual o nome do dono da passagem ?");
                var nome = Console.ReadLine();
                Console.WriteLine($"");
                

                Console.WriteLine($"Qual a origem do voo ?");
                var origem = Console.ReadLine();
                Console.WriteLine($"");

                Console.WriteLine($"Qual o destino do voo ?");
                var destino = Console.ReadLine();
                Console.WriteLine($"");   

                Console.WriteLine($"Qual a data do voo ?\nEscreva no formato: xx/yy/zz");
                var dataDoVoo = Console.ReadLine();
                Console.WriteLine($"");

                Console.WriteLine($"Passagem Cadastrada com sucesso! Gostaria de cadastrar outra passagem ?\n(Digite S para sim e N para Nao)");
                var continuar = char.Parse(Console.ReadLine());
                while (continuar != 's' && continuar != 'n')
                {
                    Console.WriteLine($"Desculpe, nao entendi, favor digitar novamente!\nGostaria de cadastrar outra passagem ?\n(Digite S para sim e N para Nao)");
                    continuar = char.Parse(Console.ReadLine());
                }
                if (continuar == 's')
                {
                    return CadastroPassagens();
                }
                else
                {
                    return "Aqui estao as passagens listadas:"; 
                    Console.WriteLine($"Aqui estao as passagens listadas:");
                    
                }
                
            }

            string nome;

            string origem;

            string destino;

            string dataDoVoo;

            char continuar;
            
            string senha;

            char escolha;

            Console.WriteLine($"Antes de comecarmos, digite sua senha:");
            senha = Console.ReadLine();
            Console.WriteLine($"");

            while (Login(senha))
            {
                Console.WriteLine($"Senha incorreta!, digite novamente:");
                senha = Console.ReadLine();
                Console.WriteLine($"");
                
            }

            Console.WriteLine($"Acesso liberado, gostaria de cadastrar alguma passagem ?\n(Digite S para sim e N para Nao)");
            escolha = char.Parse(Console.ReadLine());

            while (escolha !='s' && escolha !='n')
                {
                    Console.WriteLine($"Algo foi digitado incorretamente! Digite novamente!\nGostaria de cadastrar alguma passagem ?\n(Digite S para sim e N para Nao)");
                    escolha = char.Parse(Console.ReadLine());
                }

            switch (escolha)
            {
                case 's':
                CadastroPassagens();
                    break;
                default:
                Console.WriteLine($"Certo, encerrando programa de cadastro...");
                    break;
            }
            
            
            
        }
    }
}
