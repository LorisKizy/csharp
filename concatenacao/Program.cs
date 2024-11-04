// Concatenacao "coisa" + "coisa" + "coisa"
string nome = "Joao";
string saudacao = "Ola " + nome +"! Bem-vindo.";
Console.WriteLine(saudacao);

// Interpolacao $ "coisa {} coisa"

string nome = "Joao";
string saudacao1 = $"Ola,{nome}! Bem Vindo.";
Console.WriteLine(saudacao1);


// (coisa.GetType())
int numero = 5;
Console.WriteLine(numero.GetType());

// Palavra-Chave typeof
Console.WriteLine(typeof(int));

//Metodo parse
string valorTexto = "100";
Console.WriteLine("A variavel valorTexto e do tipo: " + valorTexto.GetType());

//conversao de string para numero apenas dos tipos primitivos