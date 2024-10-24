public class TimerService 
{
    private static TimerService instance;

    public static TimerService Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new TimerService();
            }
            return instance;
        }
    }

    public float GetEnrichmentTime(ResourceType resourceType)
    {
        return 0f;
    }

    public float GetDecayTime(ResourceType resourceType)
    {
        return 0f;
    }
}
