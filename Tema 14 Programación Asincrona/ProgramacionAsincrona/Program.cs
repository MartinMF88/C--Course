using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

// Programación asincrona
Stopwatch sw = Stopwatch.StartNew();

// Task 1

var task1 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task 1:  { crono.Elapsed}");
});


// Task 2

var task2 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task 2:  {crono.Elapsed}");
});

// Task 3

var task3 = new Task(() =>
{
    Stopwatch crono = new Stopwatch();
    crono.Start();
    Thread.Sleep(1000);
    crono.Stop();
    Console.WriteLine($"Task 3:  {crono.Elapsed}");
});
var task4 = new Task(async () =>
{
    var str = await RandomAsync();
    Console.WriteLine(str);
});

task1.Start();
//codigo
task2.Start();
//codigo
task3.Start();
//codigo
task4.Start();

await task1;
await task2;
await task3;
await task4;

var str = await RandomAsync();
Console.WriteLine(str);

sw.Stop();
Console.WriteLine($"Main: {sw.Elapsed}");


static async Task<string> RandomAsync()
    {
    Stopwatch sw = Stopwatch.StartNew();
    var num = new Random().Next(1000);
    Thread.Sleep(1000);
    sw.Stop();
    var str = $"{num.ToString()} calculado en: {sw.Elapsed}";
    //Console.WriteLine(str);
    return str;
    }