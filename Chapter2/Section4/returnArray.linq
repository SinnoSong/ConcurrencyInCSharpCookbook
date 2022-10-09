<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

var task1 = Task.FromResult(3);
var task2 = Task.FromResult(5);
var task3 = Task.FromResult(7);

int[] result = await Task.WhenAll(task1, task2, task3);
Console.WriteLine(result);