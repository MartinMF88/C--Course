// OPERADORES
// ARITMETICOS (+ - * /) / MODULO(%) / AUTOINCREMENTO (++) / AUTODECREMENTO (--)

/*

int i = 4;
// Console.WriteLine("Suma: " + (i+1));
// Autoincrementos
Console.WriteLine("Autoincremento: " + ++i);
Console.WriteLine("Autodecremento: " + --i);
Console.WriteLine("Valor: " + i);

Console.WriteLine("Division: " + i );
Console.WriteLine("Division: " + i / 4); // Resultado es entero

*/

// Operadores de asignacion

int j = 1;
int k = 2;
// j = j + 3;
/* Console.WriteLine("Sumo 3: " + (j+=3));
Console.WriteLine("j: " + j); // el valor de j se actualiza y se guarda en la memoria

Console.WriteLine("Resto 1: " + (j -= 1));
Console.WriteLine("j: " + j); // el valor de j se actualiza y se guarda en la memoria
*/


// OPERADORES DE COMPARACION

/*
Console.WriteLine("Iguales? " + (j==k));
Console.WriteLine("j mayor? " + (j > k));
Console.WriteLine("j menor? " + (j < k));
Console.WriteLine("j menor o igual? " + (j <= k));
*/

// OPERADORES LOGICOS / Logical and(&&) / Logical or (||) / Logical not (!)
int a = 9;
int b = 11;
// Y - AND (&&)
Console.WriteLine("And - Y");
Console.WriteLine("True True: " + (a<10 && b> 10));
Console.WriteLine("False True: " + (a > 10 && b > 10));
Console.WriteLine("True False: " + (a < 10 && b < 10));
Console.WriteLine("False False: " + (a > 10 && b < 10));
// En los Y, en las tablas de verdad, si al menos hay un falso, todo se hace falso.

// O - OR
Console.WriteLine("OR - O");
Console.WriteLine("True True: " + (a < 10 || b > 10));
Console.WriteLine("False True: " + (a > 10 || b > 10));
Console.WriteLine("True False: " + (a < 10 || b < 10));
Console.WriteLine("False False: " + (a > 10 || b < 10));
// En los "O", en las tablas de verdad, si al menos hay un verdadero, todo se hace verdadero.

// NO - NOT
Console.WriteLine("NOT - NO");
Console.WriteLine("True: " + !(a < 10));
Console.WriteLine("False: " + !(b < 10));
// En los "NO", invierte los valores de veracidad. True lo convierte en false y viceversa.
