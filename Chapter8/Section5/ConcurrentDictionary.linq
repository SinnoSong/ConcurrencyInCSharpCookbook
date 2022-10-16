<Query Kind="Statements">
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

var dictionary = new ConcurrentDictionary<int, string>();
var newValue = dictionary.AddOrUpdate(0, key => "Zero", (key, oldValue) => "Zero");
dictionary[1] = "One";
foreach (var item in dictionary)
{
	Console.WriteLine(item.Key + item.Value);
}
string currentValue;
bool keyExists = dictionary.TryGetValue(0, out currentValue);
Console.WriteLine(currentValue);
string removedValue;
bool keyExisted = dictionary.TryRemove(0, out removedValue);
Console.WriteLine(removedValue);
foreach (var item in dictionary)
{
	Console.WriteLine(item.Key + item.Value);
}