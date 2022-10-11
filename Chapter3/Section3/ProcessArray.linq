<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

static void ProcessArray(double[] array)
{
	Parallel.Invoke(
		() => ProcessPartialArray(array, 0, array.Length / 2),
		() => ProcessPartialArray(array, array.Length / 2, array.Length)
	);
}
static void ProcessPartialArray(double[] array, int begin, int end)
{
	throw new NotImplementedException();
}