<Query Kind="Statements">
  <Namespace>System.Collections.Immutable</Namespace>
</Query>

var sortedDictionary = ImmutableSortedDictionary<int, string>.Empty;
sortedDictionary = sortedDictionary.Add(10, "Ten");
sortedDictionary = sortedDictionary.Add(21, "Twenty-One");
sortedDictionary = sortedDictionary.SetItem(10, "Diez");

// 先显示“10Diez”，接着显示“21Twenty-One”。
foreach (var item in sortedDictionary)
	Console.WriteLine(item.Key + item.Value);

var ten = sortedDictionary[10];
// ten == "Diez"

sortedDictionary = sortedDictionary.Remove(21);