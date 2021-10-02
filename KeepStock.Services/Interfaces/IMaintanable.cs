namespace KeepStock.Services.Interfaces
{
    public interface IMaintanable<T>
    {
        T Create(T obj);
        T Retrieve(string key);
        T Update(T obj);
        bool Delete(string key);
    }
}
