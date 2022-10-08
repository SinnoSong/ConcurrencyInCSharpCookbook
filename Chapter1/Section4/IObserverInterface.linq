<Query Kind="Statements" />

interface IObserver<in T>
{
	void OnNext(T item);
	void OnCompleted();
	void OnError(Exception error);
}
interface IObservable<out T>
{
	IDisposable Subscribe(IObserver<T> observer);
}