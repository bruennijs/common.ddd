namespace Common.Ddd.Infrastructure.Persistence
{
	public class Entity
	{
    	public Id Id { get; private set; }

	    protected Entity(Id id)
	    {
	        Id = id;
	    }
	}
}