<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static Task<T> NotImplementedAsync<T>()
{
	var tcs = new TaskCompletionSource<T>();
	tcs.SetException(new NotImplementedException());
	return tcs.Task;
}