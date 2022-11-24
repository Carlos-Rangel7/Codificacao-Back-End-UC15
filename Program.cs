using Back_End_ER02.Classes;
using Back_End_ER04.Classes;

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

Console.WriteLine(@$"Nome:{novaPF.nome}
Endereço: {novaPF.endereco.Logradouro}
Numero: {novaPF.endereco.Numero}
{novaPF.endereco.Complemento}
{novaPF.endereco.EndComercial}");





// Console.WriteLine(novaPF.nome);
// Console.WriteLine(novaPF.cpf);
// Console.WriteLine(novaPF.rendimento);
// Console.WriteLine(novaPF.CalcularImposto (1200));
// Concatenação usa + e interpolação usa $

//Pessoa Fisica ======================================================
// float ImpostoApagar = novaPF.CalcularImposto (novaPF.rendimento);
// Console.WriteLine(ImpostoApagar);
// Console.WriteLine(ImpostoApagar.ToString("C2"));


// // Pessoa Juridica ===================================================================
// PessoaJuridica novaPj = new PessoaJuridica ();
// Console.WriteLine(novaPj.CalcularImposto(6600.5f));

// DateTime temp = new DateTime (2005, 01, 01);
// Console.WriteLine(novaPF.ValidarDataNasc("01/01/2000"));







