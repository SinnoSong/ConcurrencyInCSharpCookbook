<Query Kind="Statements">
  <Namespace>System.Drawing.Drawing2D</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

int InvertMatrices(IEnumerable<Matrix> matrices)
{
	object mutex = new Object();
	int nonInvertibleCount = 0;
	Parallel.ForEach(matrices, matrix =>
	 {
		 if (matrix.IsInvertible)
		 {
			 matrix.Invert();
		 }
		 else
		 {
			 lock (mutex)
			 {
				 ++nonInvertibleCount;
			 }
		 }
	 });
	return nonInvertibleCount;
}