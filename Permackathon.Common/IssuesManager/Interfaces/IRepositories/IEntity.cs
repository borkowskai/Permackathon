namespace Permackathon.Common.IssuesManager.Interfaces.IRepositories
{
    public interface IEntity<TKey> /*where TKey : struct*//*????core ne reconnait pas struct*/
    {
        TKey Id { get; }
        //TODO - check if set needed
    }

}