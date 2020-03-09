namespace Permackathon.Common.Interfaces.IRepositories
{
    public interface IEntity<TKey> where TKey : struct
    {
        TKey Id { get; }
    }

}