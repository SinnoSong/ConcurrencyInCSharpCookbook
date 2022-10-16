<Query Kind="Statements">
  <Namespace>System.Collections.Immutable</Namespace>
</Query>

var stack = ImmutableStack<int>.Empty;
stack = stack.Push(13);
var biggerStack = stack.Push(7);

foreach (var item in biggerStack)
{
	Console.WriteLine(item);
}
foreach (var item in stack)
{
	Console.WriteLine(item);
}