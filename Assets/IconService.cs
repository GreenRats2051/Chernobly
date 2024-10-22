using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconService : MonoBehaviour
{
    private static IconService instance;

    public static IconService Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new IconService();
            }
            return instance;
        }
    }

    public void SetActiveIcon(Transform target, Sprite sprite)
    {

    }

    public void SetInactiveIcon(Transform target, Sprite sprite)
    {

    }
}
