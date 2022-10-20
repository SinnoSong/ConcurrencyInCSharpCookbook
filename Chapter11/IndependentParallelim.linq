<Query Kind="Statements">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void IndependentParallelim(IEnumerable<int> values)
{
	Parallel.ForEach(values, item => Console.WriteLine(item));
}