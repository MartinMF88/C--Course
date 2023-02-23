// Multithreading
using System;
using System.Diagnostics;
using System.Threading;

Stopwatch crono = Stopwatch.StartNew();
//task 1
var task1 = new Task(() =>
{
    var crono = Stopwatch.StartNew();
    Thread.Sleep(1000); // PARAR ESTE HILO 1 SEGUNDO
    crono.Stop();
    Console.WriteLine($"1. El hilo ha tardado: {crono.Elapsed}");
});
//task 2
var task2 = new Task(() =>
{
    var crono = Stopwatch.StartNew();
    Thread.Sleep(1000); // PARAR ESTE HILO 1 SEGUNDO
    crono.Stop();
    Console.WriteLine($"2. El hilo ha tardado: {crono.Elapsed}");
});
//task 3
var task3 = new Task(() =>
{
    var crono = Stopwatch.StartNew();
    Thread.Sleep(1000); // PARAR ESTE HILO 1 SEGUNDO
    crono.Stop();
    Console.WriteLine($"3. El hilo ha tardado: {crono.Elapsed}");
});

//Iniciamos los tasks o tareas
task1.Start();
task2.Start();
task3.Start();

// Recibir las tareas
// await Task.WhenAll(task1, task2 task3); Con esta notacion recibimos todas las tareas iniciadas cuando se completan
await task1;
await task2;
await task3;
crono.Stop();
Console.WriteLine($"Todo el programa ha durado: {crono.Elapsed}");

// Recolectamos los tasks completados
// Finalizamos el programa
