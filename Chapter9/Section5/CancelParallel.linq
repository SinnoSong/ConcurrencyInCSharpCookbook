<Query Kind="Statements">
  <Namespace>System.Drawing.Drawing2D</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static void RotateMatrices(IEnumerable<Matrix> matrices, float degrees, CancellationToken token)
{
	Parallel.ForEach(matrices,
		new ParallelOptions { CancellationToken = token },
		matrix => matrix.Rotate(degrees));
}
static void RotateMatrices2(IEnumerable<Matrix> matrices, float degrees, CancellationToken token)
{
	// 不推荐
	Parallel.ForEach(matrices, matrix =>
	{
		matrix.Rotate(degrees);
		token.ThrowIfCancellationRequested();
	});
}
static IEnumerable<int> MultiplyBy2(IEnumerable<int> values, CancellationToken cancellationToken)
{
	return values.AsParallel()
	.WithCancellation(cancellationToken)
	.Select(item => item * 2);
}