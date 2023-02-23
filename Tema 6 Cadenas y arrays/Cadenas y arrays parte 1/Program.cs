// distintas formas de declarar un string nulo

string str;
string str2 = null;
string str3 = System.String.Empty;
string str4 = "";
string str5 = " ";
// Tipo y salida
Console.WriteLine(str3.GetType());
Console.WriteLine($"str3: {str5}");
Console.WriteLine(str5.GetType());

// Concatenacion

string msg1 = "Buenos dias";
// codigo
string msg2 = "estoy programando en C#";
// IMPRIMIR UN MENSAJE

Console.WriteLine(msg1 + ", " + msg2 + ".");

string msg3 = msg1 + msg2;
string msg4 = msg1; // mensaje completo
msg4 += msg2;
Console.WriteLine(msg4);

// Literales
// Caracteres escapados -> \n \u00C6 (Æ) \r \t

string columns = "Column 1\tColumn 2\tColumn 3";
string content = "contenido1 \ncontenido1 \ncontenido1 \tcontenido2 contenido2 contenido2\tcontenido3 contenido3 contenido3";
Console.WriteLine(columns);
Console.WriteLine(content);

string rows = "contenido1 contenido1 contenido1 \r\ncontenido2 contenido2 contenido2\r\nRow3";
Console.WriteLine(rows);

// Algunos caracteres escapados: \' \" \\ \v etc.

string multilinea = "Hola, " +
    "Este es un mensaje" +
    "en varias lineas";
string multilinea2 = @"Hola, este
    es un mensaje de
    varias lineas
    sin contatenar";

string comillas = @"El se autoproclama ""programador"".";
Console.WriteLine("Comillas: " + comillas);

// Interpolacion , el simbolo $ se usa para introducir variables dentro de su mensaje

var persona = (nombre: "Martin", nacimiento: 1988, edad: "34", lenguaje: "C#");
Console.WriteLine($"{persona.nombre} es un hombre de {2022 - persona.nacimiento} " +
    $"años y le gusta programar en {persona.lenguaje}");

// Subcadenas
string miCadena = "  Este es mi mensaje   ";
//Substring, Replace
string miCadena2 = miCadena.Substring(0, 10);
Console.WriteLine(miCadena2);
string miCadena3 = miCadena.Replace("mensaje", "diccionario"); // el primer factor es el elemento a eliminar, y el segundo es el sustituto
Console.WriteLine(miCadena3);
// Limpiar espacios
string miCadena4 = miCadena.Trim(); // el trim elimina los espacios indeseados
Console.WriteLine(miCadena4);
// Encontrar algun caracter
int index = miCadena.IndexOf("m");
Console.WriteLine(index);
