using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Bootstrapper;

[System.Serializable]
public class ResourceTimerData : MonoBehaviour
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
