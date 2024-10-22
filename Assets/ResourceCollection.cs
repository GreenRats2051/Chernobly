using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ResourceCollection", menuName = "ScriptableObjects/ResourceCollection", order = 1)]
public class ResourceCollection : ScriptableObject
{
    public ResourceData[] resources;
}
