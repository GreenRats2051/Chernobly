using UnityEngine;
using UnityEngine.UI;

namespace Ui
{
    public class IconService
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

        public void SetActiveIcon(Image image, Sprite sprite)
        {
            image.sprite = sprite;
        }

        public void SetInactiveIcon(Image image, Sprite sprite)
        {
            image.sprite = sprite;
        }
    }
}
