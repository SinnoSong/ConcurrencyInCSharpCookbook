<Query Kind="Statements">
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
</Query>

try
{
	var multiplyBlock = new TransformBlock<int, int>(item =>
	{
		if (item == 1)
		{
			throw new InvalidOperationException("Blech.");
		}
		return item * 2;
	});
	var subtractBlock = new TransformBlock<int, int>(item => item - 2);
	multiplyBlock.LinkTo(subtractBlock, new DataflowLinkOptions { PropagateCompletion = true });
	multiplyBlock.Post(1);
	subtractBlock.Completion.Wait();
}
catch (AggregateException exception)
{
	AggregateException ex = exception.Flatten();
	Console.WriteLine(ex.InnerException);
}