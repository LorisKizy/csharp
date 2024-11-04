// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//operadores logicos
//n pode ser nome de variavel igual (ex.: a em todos os operadores)
//E logico &&
bool a = true;
bool b = false;
Console.WriteLine(a&&b);

//NOT logico !
bool a1 = true;
Console.WriteLine(!a1);

//OU logico ||
bool a2 = true;
bool b2 = false;
Console.WriteLine(a2||b2);

//XOR logico ^ (OU Exclusivo)
bool c = true;
bool d = false;
Console.WriteLine(c^d);

//Precedencia ordem de operacoes logicas

bool e = true;
bool f = false;
bool g = false;
bool resultado = !e || (f&&g);
Console.WriteLine(resultado);

