<Query Kind="Statements">
  <Namespace>System.Drawing.Drawing2D</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void RotateMatrices(IEnumerable<Matrix> matrices, float degrees, CancellationToken token)
{
	Parallel.ForEach(matrices,
		new ParallelOptions { CancellationToken = token },
		matrix => matrix.Rotate(degrees));
}