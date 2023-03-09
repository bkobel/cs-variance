namespace Default;

public interface IProvider<out T>
{
    T Provide { get; }
}

public interface IHelper<in T>
{
    void HelpWithT(IProvider<T> t);
}

public interface IAnotherHelper<out T>
{
    IProvider<T> Provider { get; }
}

public interface IContext<out T> 
{
    IAnotherHelper<T> Test { get; }
    
    void Execute(IHelper<T> helper);
}