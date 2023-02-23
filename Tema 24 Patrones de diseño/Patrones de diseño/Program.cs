// Patrones de diseño

Singleton s1 = Singleton.GetInstance();
Singleton s2 = Singleton.GetInstance();

if (s1 == s2)
{
    Console.WriteLine("Singleton funciona");
}
else
{
    Console.WriteLine("Singleton falló, las instancias son diferentes");
}