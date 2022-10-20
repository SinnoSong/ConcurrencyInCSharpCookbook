<Query Kind="Statements">
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
  <Namespace>System.Drawing.Drawing2D</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

IPropagatorBlock<int, int> DataflowMultiplyBy2()
{
	var options = new ExecutionDataflowBlockOptions
	{
		MaxDegreeOfParallelism = 10
	};

	return new TransformBlock<int, int>(data => data * 2, options);
}
// use PLINQ
IEnumerable<int> ParallelMultiplyBy2(IEnumerable<int> values)
{
	return values.AsParallel()
	.WithDegreeOfParallelism(10)
	.Select(item => item * 2);
}
// use Parallel
void ParallelRotateMatrices(IEnumerable<Matrix> matrices, float degrees)
{
	var options = new ParallelOptions { MaxDegreeOfParallelism = 10 };
	Parallel.ForEach(matrices, options, matrix => matrix.Rotate(degrees));
}