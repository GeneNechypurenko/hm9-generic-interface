using hm9;

MyArray array = new MyArray(2);
Random rnd = new Random();

array.ReSize(10);

array.InitWithRand(9, 99);

Console.WriteLine(array);

int valueToCompare = rnd.Next(9, 99);

Console.WriteLine($"LESS then {valueToCompare} = {array.Less(valueToCompare)}\n");
Console.WriteLine($"GREATER then {valueToCompare} = {array.Greater(valueToCompare)}\n");

array.ShowEven();
array.ShowOdd();