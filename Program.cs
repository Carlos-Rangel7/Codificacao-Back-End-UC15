using Back_End_ER02.Classes;
using Back_End_ER04.Classes;
using Back_End_ER06.Classes;


List<PessoaFisica> listaPf = new List<PessoaFisica>();

Console.Clear();
Utils.BarraCarregamento("Carregando");

string? opcao;

do
{
    Console.Clear();

    Console.WriteLine(@$"
============================================   
|       Bem Vindo ao Sistema de Cadastro   |
|          Pessoa Física & Juridica        |
============================================ 
|           1 - Pessoa Física              |
|           2 - Pessoa Juridica            |
|                                          |
|           0 - Sair                       |
=============================================
");

    opcao = Console.ReadLine();
    PessoaFisica metodoPf = new PessoaFisica();

    switch (opcao)
    {

        case "1":

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
            ============================================   
            |     Escolha uma das opções abaixo        |
            |------------------------------------------|                 
            |          1 Cadastra Pessoa Física        |
            |          2 Listar Pessoa Física          |
            |                                          |
            |          0  Volta ao menu anterior       |
            ============================================                                          
            ");
                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    case "1":
                        Console.Clear();

                        PessoaFisica novaPf = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da pessoa física, tecle Enter ao final");
                        novaPf.nome = Console.ReadLine();

                        // bool dataValida;
                        // do
                        // {
                        //     Console.WriteLine($"Digite sua data de nascimento Ex: DD/MM/AAAA");
                        //     string? dataNascimento = Console.ReadLine();

                        //     dataValida = novaPf.ValidarDataNasc(dataNascimento);

                        //     if (dataValida)
                        //     {
                        //         DateTime.TryParse(dataNascimento, out DateTime dataConvertida);
                        //         novaPf.dataNasc = dataConvertida;
                        //     }
                        //     else
                        //     {
                        //         Console.ForegroundColor = ConsoleColor.DarkRed;
                        //         Console.WriteLine($"Erro Data Invalida, digite um valor Válido, Ex: DD/MM/AAAA");
                        //         Console.ResetColor();
                        //         Thread.Sleep(3000);
                        //     }

                        // } while (dataValida == false); // repetir enquanto for falsa

                        // Console.WriteLine($"Digite o numero do seu CPF e pressione enter");
                        // novaPf.cpf = Console.ReadLine();

                        // Console.WriteLine($"Digite o valor do seu rendimento mensal");
                        // novaPf.rendimento = float.Parse(Console.ReadLine()); // float casa decimais

                        // Console.WriteLine($"Digite o logradouro");
                        // novoEndPf.Logradouro = Console.ReadLine();

                        // Console.WriteLine($"Digite o numero do seu Endereço");
                        // novoEndPf.Numero = int.Parse(Console.ReadLine()); // int numero inteiro

                        // Console.WriteLine($"Digite o Complemento");
                        // novoEndPf.Complemento = Console.ReadLine();

                        // Console.WriteLine($"Este Endereçoi é comercial? S/N");
                        // String endCom = Console.ReadLine().ToUpper();

                        // if (endCom == "S")
                        // {
                        //     novoEndPf.EndComercial = true;
                        // }
                        // else
                        // {
                        //     novoEndPf.EndComercial = false;
                        // }

                        // novaPf.endereco = novoEndPf;

                        // listaPf.Add(novaPf);

                        // Grava o nome e gera um arquivo txt Exp 1
                        // StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt");
                        // sw.WriteLine(novaPf.nome);
                        // sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
                        {
                            sw.WriteLine(novaPf.nome);
                        }

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Cadastro concluido com sucesso");
                        Console.ResetColor();
                        Thread.Sleep(2000);

                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"Cadastro Gravado");
                        Console.ResetColor();
                        Thread.Sleep(3000);

                        break;

                    case "2":
//                         Console.Clear();

//                         if (listaPf.Count > 0)
//                         {
//                             foreach (PessoaFisica cadaPessoa in listaPf)
//                             {
//                                 Console.Clear();
//                                 Console.WriteLine($@"
// Nome: {cadaPessoa.nome}
// Endereço: {cadaPessoa.endereco.Logradouro}, {cadaPessoa.endereco.Numero}
// Imposto a ser pago: {metodoPf.CalcularImposto(cadaPessoa.rendimento).ToString("C")}
// Data Nascimento : {cadaPessoa.dataNasc.ToString("d")}
// ");
//                             }
//                             Console.WriteLine($"Aperte ENTER para continuar");
//                             Console.ReadLine();
//                         }
//                         else
//                         {
//                             Console.Clear();
//                             Console.ForegroundColor = ConsoleColor.Green;
//                             Console.WriteLine($"Lista Vazia, Cadastre uma nova Pessoa Física");
//                             Console.ResetColor();
//                             Thread.Sleep(3000);
//                         }

                        using (StreamReader sr = new StreamReader("Carlos Rangel.txt"))
                        {
                            string linha;

                            while ((linha  = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(linha);
                            }
                            Console.WriteLine($"Tecle enter para continuar");                            
                            Console.ReadLine();
                            
                        }

                         break;

                    case "0":
                        Console.Clear();
                        Console.WriteLine($"Voltando ao menu anteerior");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Invalida, por favor digite uma opção Valida");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }
            } while (opcaoPf != "0");



            Console.WriteLine($"Pessoa Física");
            PessoaFisica novaPF = new PessoaFisica();
            Endereco novoEndPF = new Endereco();

            novaPF.nome = "Carlos Rangel";
            novaPF.cpf = "52029988851";
            novaPF.rendimento = 6600.5f;
            novaPF.dataNasc = new DateTime(2002, 12, 20);

            novoEndPF.Logradouro = "Av. Maria cursi";
            novoEndPF.Numero = 1131;
            novoEndPF.Complemento = "Casa";
            novoEndPF.EndComercial = false;

            novaPF.endereco = novoEndPF;

            Console.WriteLine(@$"
        Nome: {novaPF.nome}
        Rendimento: {novaPF.rendimento}
        CPF: {novaPF.cpf}
        Logradouro: {novaPF.endereco.Logradouro}
        Numero: {novaPF.endereco.Numero}
        ");
            // Console.WriteLine(novaPF.nome);
            // Console.WriteLine(novaPF.cpf);
            // Console.WriteLine(novaPF.rendimento);
            // // Console.WriteLine(novaPF.CalcularImposto (1200));
            // // Concatenação usa + e interpolação usa $
            Thread.Sleep(5000);
            break;



        case "2":
            Console.WriteLine($"Pessoa Juridica");
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();
            PessoaJuridica metodosPj = new PessoaJuridica();

            novaPj.nome = "Nome Pj2 ";
            novaPj.razaoSocial = "Razão social PJ2";
            novaPj.cnpj = "00.476.645/0001-04";
            novaPj.rendimento = 10000.5f;
            novoEndPj.Logradouro = "Maria Cursi";
            novoEndPj.Numero = 1131;
            novoEndPj.Complemento = "Casa";
            novoEndPj.EndComercial = false;
            // Console.WriteLine(novaPj.ValidarCnpj("00.476.645/0001-03"));

            novaPj.endereco = novoEndPj;
            metodosPj.Inserir(novaPj);

            // Console.Clear();
            // Console.WriteLine(@$"
            // Nome: {novaPj.nome}
            // Razão Social: {novaPj.razaoSocial}
            // CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
            // ");

            // Console.WriteLine($"Tecle Enter para sair");
            // Console.ReadLine();

           List<PessoaJuridica> ListaExibiçaoPj = metodosPj.LerArquivo();

           foreach (PessoaJuridica CadaItem in ListaExibiçaoPj)
           {
                Console.Clear();
                Console.WriteLine(@$"
Nome: {CadaItem.nome}
Razão Social: {CadaItem.razaoSocial}
CNPJ: {CadaItem.cnpj}");

            Console.WriteLine($"Tecle Enter para sair");
            Console.ReadLine();
                
           }
            
            break;

        case "0":
            Console.WriteLine($"Finalizado");

            break;

        default:
            Console.WriteLine($"Opção invalida");

            break;
    }

} while (opcao != "0");

Utils.BarraCarregamento("Finalizando");













// Thread.Sleep (6000);

// Console.Clear();



// // Pessoa Fisica ======================================================
// float ImpostoApagar = novaPF.CalcularImposto (novaPF.rendimento);
// Console.WriteLine(ImpostoApagar);
// Console.WriteLine(ImpostoApagar.ToString("C2"));


// // Pessoa Juridica ===================================================================
// PessoaJuridica novaPj = new PessoaJuridica ();
// Console.WriteLine(novaPj.CalcularImposto(6600.5f));

// DateTime temp = new DateTime (2005, 01, 01);
// Console.WriteLine(novaPF.ValidarDataNasc("01/01/2000"));


// Encontro remoto 5



// ");






