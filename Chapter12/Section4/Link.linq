<Query Kind="Statements">
  <Namespace>System.Threading.Tasks.Dataflow</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Windows.Controls</Namespace>
</Query>

ListBox listBox = new ListBox();
var options = new ExecutionDataflowBlockOptions
{
	TaskScheduler = TaskScheduler.FromCurrentSynchronizationContext()
};
var multiplyBlock = new TransformBlock<int, int>(item => item * 2);
var displayBlock = new ActionBlock<int>(result => listBox.Items.Add(result), options);
multiplyBlock.LinkTo(displayBlock);