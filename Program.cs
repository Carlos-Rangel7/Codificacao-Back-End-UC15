using Back_End_ER02.Classes;

PessoaFisica novaPF = new PessoaFisica();

novaPF.nome = "Carlos Rangel";
novaPF.cpf = "52029988851";
novaPF.rendimento = 6600.5f;

// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine(novaPF.rendimento);
// Console.WriteLine(novaPF.CalcularImposto (1200));
// Concatenação usa + e interpolação usa $

//Pessoa Fisica ======================================================
float ImpostoApagar = novaPF.CalcularImposto (novaPF.rendimento);
Console.WriteLine(ImpostoApagar);
Console.WriteLine(ImpostoApagar.ToString("C2"));


// Pessoa Juridica ===================================================================
PessoaJuridica novaPj = new PessoaJuridica ();
Console.WriteLine(novaPj.CalcularImposto(6600.5f));






