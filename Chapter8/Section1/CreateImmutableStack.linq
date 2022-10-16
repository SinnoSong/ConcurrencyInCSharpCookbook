<Query Kind="Statements">
  <Namespace>System.Collections.Immutable</Namespace>
</Query>

var stack = ImmutableStack<int>.Empty;
stack = stack.Push(13);
stack = stack.Push(7);
foreach (var item in stack)
{
	Console.WriteLine(item);
}
int lastItem;
stack.Pop(out lastItem);
Console.WriteLine(lastItem);