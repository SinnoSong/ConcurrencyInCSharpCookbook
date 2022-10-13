<Query Kind="Statements">
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
</Query>

var multiplyBlock = new TransformBlock<int, int>(
	item => item * 2,
	new ExecutionDataflowBlockOptions
	{
		MaxDegreeOfParallelism = DataflowBlockOptions.Unbounded
	}
);
var subtractBlock = new TransformBlock<int, int>(item => item - 2);
multiplyBlock.LinkTo(subtractBlock);