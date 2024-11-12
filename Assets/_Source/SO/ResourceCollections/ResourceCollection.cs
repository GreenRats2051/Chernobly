using UnityEngine;
using Game;

[CreateAssetMenu(fileName = "ResourceCollection", menuName = "ScriptableObjects/ResourceCollection", order = 1)]
public class ResourceCollection : ScriptableObject
{
    public ResourceData[] resources;
}
