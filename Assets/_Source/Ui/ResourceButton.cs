using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Ui
{
    public class ResourceButton : MonoBehaviour
    {
        public Image image;
        public ResourceType resourceType;
        public ResourceCollection resourceCollection;
        public ResourceTimerCollection resourceTimeData;
        public int index;

        private Button button;

        private void Start()
        {
            button = GetComponent<Button>();
            Initialize();
        }

        private void Initialize()
        {
            button.onClick.AddListener(StartEnrichment);
        }

        private void StartEnrichment()
        {
            StartCoroutine(EnrichmentCoroutine());
        }

        private IEnumerator EnrichmentCoroutine()
        {
            IconService.Instance.SetInactiveIcon(image, resourceCollection.resources[index].inactiveSprite);
            button.interactable = false;
            yield return new WaitForSeconds(resourceTimeData.resourceTimers[index].enrichmentTime);
            IconService.Instance.SetActiveIcon(image, resourceCollection.resources[index].activeSprite);
            button.interactable = true;
            StartCoroutine(DecayCoroutine());
        }

        private IEnumerator DecayCoroutine()
        {
            yield return new WaitForSeconds(resourceTimeData.resourceTimers[index].decayTime);
            Game.Game.Instance.GameOver();
        }
    }
}
