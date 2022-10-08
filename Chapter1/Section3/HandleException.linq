<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

try
{
	Parallel.Invoke(() => { throw new Exception(); },
		() => { throw new Exception(); }
	);
}
catch (AggregateException ex)
{
	ex.Handle(exception =>
	{
		Trace.WriteLine(exception);
		return true; //表示已经处理
	});
	throw;
}