using MinStack;

MyMinStack minStack = new MyMinStack();

/*

minStack.Push(100);
minStack.Push(200);
minStack.Push(50);

Console.WriteLine($"GetMin: {minStack.GetMin()}");
Console.WriteLine($"Pop: {minStack.Pop()}");
Console.WriteLine($"GetMin: {minStack.GetMin()}");

*/

minStack.Push(100);
minStack.Push(200);
minStack.Push(50);
minStack.Push(300);
minStack.Push(400);

Console.WriteLine($"GetMin: {minStack.GetMin()}");
Console.WriteLine($"Pop: {minStack.Pop()}");
Console.WriteLine($"GetMin: {minStack.GetMin()}");
Console.WriteLine($"Pop: {minStack.Pop()}");
Console.WriteLine($"Pop: {minStack.Pop()}");
Console.WriteLine($"GetMin: {minStack.GetMin()}");