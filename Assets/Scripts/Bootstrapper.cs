using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class Bootstrapper : MonoBehaviour
{
    private void Awake()
    {
        Game.Instance.Initialize();
    }
}
