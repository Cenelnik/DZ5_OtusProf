
using ConsoleApp1.Infrastructure;



Cell Test = new SmartTreeCell("AAAAA");
Cell Test2 = Test.MyClone();
Console.WriteLine($"{Test2.Name}");
Cell Test3 = (SmartTreeCell)Test.Clone();
Console.WriteLine($"{Test3.Name}");
