using System;
using UnityEngine;

[Serializable]
public class ResourceTimerData
{
    public ResourceType resourceType;
    public float enrichmentTime;
    public float decayTime;
}

[CreateAssetMenu(fileName = "ResourceTimerCollection", menuName = "ScriptableObjects/ResourceTimerCollection", order = 2)]
public class ResourceTimerCollection : ScriptableObject
{
    public ResourceTimerData[] resourceTimers;
}
