<Query Kind="Statements">
  <Namespace>System.Collections.Immutable</Namespace>
</Query>

var dictionary = ImmutableDictionary<int, string>.Empty;
dictionary = dictionary.Add(10, "Ten");
dictionary = dictionary.Add(21, "Twenty-One");
dictionary = dictionary.SetItem(10, "Diez");

foreach (var item in dictionary)
{
	Console.WriteLine(item.Key + item.Value);
}

var ten = dictionary[10];
dictionary = dictionary.Remove(21);
foreach (var item in dictionary)
{
	Console.WriteLine(item.Key + item.Value);
}