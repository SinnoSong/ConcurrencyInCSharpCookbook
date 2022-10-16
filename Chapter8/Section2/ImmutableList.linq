<Query Kind="Statements">
  <Namespace>System.Collections.Immutable</Namespace>
</Query>

var list = ImmutableList<int>.Empty;
list = list.Insert(0,13);
list = list.Insert(0,7);
foreach (var item in list)
{
	Console.WriteLine(item);
}

list = list.RemoveAt(1);
foreach (var item in list)
{
	Console.WriteLine(item);
}