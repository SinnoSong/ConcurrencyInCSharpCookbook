<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Collections.Immutable</Namespace>
</Query>

async Task<bool> PlayWithStackAsync()
{
	var stack = ImmutableStack<int>.Empty;

	var task1 = Task.Run(() => Trace.WriteLine(stack.Push(3).Peek()));
	var task2 = Task.Run(() => Trace.WriteLine(stack.Push(5).Peek()));
	var task3 = Task.Run(() => Trace.WriteLine(stack.Push(7).Peek()));
	await Task.WhenAll(task1, task2, task3);

	return stack.IsEmpty; // 总是返回true。
}