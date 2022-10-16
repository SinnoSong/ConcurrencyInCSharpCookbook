<Query Kind="Statements">
  <Namespace>System.Collections.Immutable</Namespace>
</Query>

var sortedSet = ImmutableSortedSet<int>.Empty;
sortedSet = sortedSet.Add(13);
sortedSet = sortedSet.Add(7);

foreach (var item in sortedSet)
{
	Console.WriteLine(item);
}
var smallestItem = sortedSet[0];
Console.WriteLine(smallestItem);
sortedSet = sortedSet.Remove(7);
foreach (var item in sortedSet)
{
	Console.WriteLine(item);
}