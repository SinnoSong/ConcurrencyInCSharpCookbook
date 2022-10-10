<Query Kind="Statements">
  <Namespace>System.Drawing.Drawing2D</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void RotateMatrices(IEnumerable<Matrix> matrices, float degrees)
{
	Parallel.ForEach(matrices, matrix => matrix.Rotate(degrees));
}