using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    public enum ResourceType
    {
        Uranium,
        Plutonium,
        Thorium
    }

    private void Awake()
    {
        Game.Instance.Initialize();
    }
}
