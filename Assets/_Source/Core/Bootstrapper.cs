using UnityEngine;

namespace Core
{
    public partial class Bootstrapper : MonoBehaviour
    {
        private void Awake()
        {
            Game.Game.Instance.Initialize();
        }
    }
}
