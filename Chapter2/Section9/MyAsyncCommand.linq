<Query Kind="Statements">
  <Namespace>System.Windows.Input</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
</Query>

sealed class MyAsyncCommand : ICommand
{
	public event EventHandler CanExecuteChanged;

	public bool CanExecute(object parameter)
	{
		throw new NotImplementedException();
	}

	async void ICommand.Execute(object parameter)
	{
		await Execute(parameter);
	}
	public async Task Execute(object parameter)
	{
		throw new NotImplementedException();
	}
}