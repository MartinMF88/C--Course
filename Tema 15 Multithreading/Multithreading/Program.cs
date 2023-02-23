// Multithreading
using System;
using System.Diagnostics;
using System.Threading;
//Sin multithreading
Stopwatch crono = new Stopwatch();
crono.Start();

//tarea 1
Thread.Sleep(1000); // esta tarea dura 1 segundo

//tarea 2
for (int i = 0; i < 1000000000; i++)
{
    i *= 1;
}

//tarea 3
Thread.Sleep(1000); // esta tarea dura 1 segundo

crono.Stop();
Console.WriteLine($"Este programa ha tardado: {crono.Elapsed}");
// Asignar nombre al Main Thread o Hilo principal
// Realizamos los tasks

Thread hiloPrincipal = Thread.CurrentThread;
hiloPrincipal.Name = "Hilo Principal";
Console.WriteLine($"Estamos en el hilo: {hiloPrincipal.Name}");

Stopwatch crono2 = new Stopwatch();
crono2.Start();
ThreadStart refHilo = new ThreadStart(IniciarHilos);
Thread hiloSecundario = new Thread(refHilo);
hiloSecundario.Start();
Thread.Sleep(1000);
crono2.Stop();
Console.WriteLine($"El hilo 2 ha tardado: {crono2.Elapsed}");

Stopwatch crono3 = new Stopwatch();
crono3.Start();
Thread hiloTercero = new Thread(refHilo);
hiloTercero.Start();
Thread.Sleep(1000);
Console.WriteLine($"El hilo 3 ha tardado: {crono3.Elapsed}");

// Recolectamos los tasks completados
// Finalizamos el programa


static void IniciarHilos()
    {
        Console.WriteLine($"Iniciando hilo nuevo...");
        Console.WriteLine($"Finalizando tareas");
}