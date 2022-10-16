<Query Kind="Statements">
  <Namespace>System.Collections.Immutable</Namespace>
</Query>

var hashSet = ImmutableHashSet<int>.Empty;
hashSet = hashSet.Add(13);
hashSet = hashSet.Add(7);

foreach (var item in hashSet)
{
	Console.WriteLine(item);
}
hashSet = hashSet.Remove(7);
foreach (var item in hashSet)
{
	Console.WriteLine(item);
}