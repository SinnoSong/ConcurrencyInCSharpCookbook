<Query Kind="Statements">
  <Namespace>System.Drawing.Drawing2D</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void RotateMatrices(IEnumerable<IEnumerable<Matrix>> collections, float degrees)
{
	var schedulerPair = new ConcurrentExclusiveSchedulerPair(TaskScheduler.Default, maxConcurrencyLevel: 8);
	TaskScheduler scheduler = schedulerPair.ConcurrentScheduler;
	ParallelOptions options = new ParallelOptions { TaskScheduler = scheduler };
	Parallel.ForEach(collections, options, matrices => Parallel.ForEach(matrices, options, matrix => matrix.Rotate(degrees)));
}