using System;
using UnityEngine;

namespace Game
{
    [Serializable]
    public class ResourceData
    {
        public ResourceType resourceType;
        public Sprite inactiveSprite;
        public Sprite activeSprite;
    }
}
