<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Collections.Concurrent</Namespace>
</Query>

async Task<int> ThreadsafeCollectionsAsync()
{
	var dictionary = new ConcurrentDictionary<int, int>();

	var task1 = Task.Run(() => { dictionary.TryAdd(2, 3); });
	var task2 = Task.Run(() => { dictionary.TryAdd(3, 5); });
	var task3 = Task.Run(() => { dictionary.TryAdd(5, 7); });
	await Task.WhenAll(task1, task2, task3);

	return dictionary.Count; // 总是返回3。
}