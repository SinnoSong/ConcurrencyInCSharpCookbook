<Query Kind="Program">
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

void Main()
{

}

class Node
{
	private int value;
	public Node left;
	public Node right;
}
void Traverse(Node current)
{
	DoExpensiveActionOnNode(current);
	if (current.left != null)
	{
		Task.Factory.StartNew(() => Traverse(current.left),
			CancellationToken.None,
			TaskCreationOptions.AttachedToParent,
			TaskScheduler.Default
		);
	}
	if (current.right != null)
	{
		Task.Factory.StartNew(() => Traverse(current.right),
					CancellationToken.None,
					TaskCreationOptions.AttachedToParent,
					TaskScheduler.Default
				);
	}
}

void ProcessTree(Node root)
{
	var task = Task.Factory.StartNew(
		() => Traverse(root),
		CancellationToken.None,
		TaskCreationOptions.None,
		TaskScheduler.Default
	);
	task.Wait();
}

void DoExpensiveActionOnNode(Node current)
{
	throw new NotImplementedException();
}
