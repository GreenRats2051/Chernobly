using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Bootstrapper;

public class ResourceButton : MonoBehaviour
{
    public ResourceType resourceType;
    private float enrichmentTime;
    private float decayTime;

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        Initialize();
    }

    private void Initialize()
    {
        enrichmentTime = TimerService.Instance.GetEnrichmentTime(resourceType);
        decayTime = TimerService.Instance.GetDecayTime(resourceType);
        button.onClick.AddListener(StartEnrichment);
    }

    private void StartEnrichment()
    {
        StartCoroutine(EnrichmentCoroutine());
    }

    private IEnumerator EnrichmentCoroutine()
    {
        IconService.Instance.SetInactiveIcon(transform, /* inactive sprite */);
        button.interactable = false;
        yield return new WaitForSeconds(enrichmentTime);
        IconService.Instance.SetActiveIcon(transform, /* active sprite */);
        button.interactable = true;
        StartCoroutine(DecayCoroutine());
    }

    private IEnumerator DecayCoroutine()
    {
        yield return new WaitForSeconds(decayTime);
        Game.Instance.GameOver();
    }
}
