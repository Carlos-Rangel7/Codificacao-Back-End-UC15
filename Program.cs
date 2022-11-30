using Back_End_ER02.Classes;
using Back_End_ER04.Classes;
using Back_End_ER06.Classes;

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
|            1   Pessoa Física             |
|                                          |
|            2   Pessoa Juridica            |
|                                          |
|            0  Sair                       |
============================================                                          

");

 opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
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

    case"2":
        Console.WriteLine($"Pessoa Juridica");
        PessoaJuridica novaPj = new PessoaJuridica();
        Endereco novoEndPj = new Endereco();
        
            novaPj.nome = "Nome Pj ";
            novaPj.razaoSocial = "Razão social PJ";
            novaPj.cnpj = "00.476.645/0001-03";

            novoEndPj.Logradouro = "Maria Cursi";
            novoEndPj.Numero = 1131;
            // Console.WriteLine(novaPj.ValidarCnpj("00.476.645/0001-03"));

            novaPj.endereco = novoEndPj;

            Console.WriteLine(@$"
            Nome: {novaPj.nome}
            Razão Social: {novaPj.razaoSocial}
            CNPJ: {novaPj.cnpj} - Valido: {novaPj.ValidarCnpj(novaPj.cnpj)}
            ");

            Console.WriteLine($"Tecle Enter para sair");
            Console.ReadLine();
            break;

    case "0":
        Console.WriteLine($"Finalizado");
        
        break;

    default:
        Console.WriteLine($"Opção invalida");
        
        break;
}

    } while (opcao !="0");

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


    
    
        

