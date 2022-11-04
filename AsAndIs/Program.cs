var texto = "teste";
//"is" ou "is not": compara o tipo do objeto ou do valor, ou verifica se é nulo ou não, além de respeitar a herança
if (texto is not null && texto is string)
    Console.WriteLine("string");

var cpf = new CPF();
if (cpf is Documento)
    Console.WriteLine("Documento"); //true
if (cpf.GetType() == typeof(Documento))
    Console.WriteLine("Documento"); //false

//"as": explicit operator, que tentará converter, e tem como vantagem que: caso contrário, retornará "null"
var documento = new Documento();
cpf = documento as CPF;

public record Documento { }
public record CPF : Documento { }
public record CI : Documento { }