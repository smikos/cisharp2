int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };
List<int> list = new List<int>();

foreach( int x in a)
{
    list.Add(x);
}
list.Sort();

foreach(int x in list)
{
    Console.WriteLine(x);
}    