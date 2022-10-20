<Query Kind="Statements">
  <Namespace>System.ComponentModel</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

class BindableTask<T> : INotifyPropertyChanged
{
	private readonly Task<T> _task;
	public BindableTask(Task<T> task)
	{
		_task = task;
		var _ = WatchTaskAsync();
	}
	private async Task WatchTaskAsync()
	{
		try
		{
			await _task;
		}
		catch
		{
		}
		OnPropertyChanged("IsNotCompleted");
		OnPropertyChanged("IsSuccessfullyCompleted");
		OnPropertyChanged("IsFaulted");
		OnPropertyChanged("Result");
	}
	public bool IsNotCompleted { get { return !_task.IsCompleted; } }
	public bool IsSuccessfullyCompleted
	{ get { return _task.Status == TaskStatus.RanToCompletion; } }
	public bool IsFaulted { get { return _task.IsFaulted; } }
	public T Result
	{ get { return IsSuccessfullyCompleted ? _task.Result : default(T); } }
	public event PropertyChangedEventHandler PropertyChanged;
	protected virtual void OnPropertyChanged(string propertyName)
	{
		PropertyChangedEventHandler handler = PropertyChanged;
		if (handler != null)
			handler(this, new PropertyChangedEventArgs(propertyName));
	}
}