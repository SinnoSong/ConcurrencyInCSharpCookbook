<Query Kind="Statements">
  <Namespace>System.Drawing.Drawing2D</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void InvertMatrices(IEnumerable<Matrix> matrices)
{
	Parallel.ForEach(matrices, (matrix, state) =>
	 {
	 	if (!matrix.IsInvertible)
		 {
			 state.Stop();
		 }
		 else
		 {
			 matrix.Invert();
		 }
	 });
}