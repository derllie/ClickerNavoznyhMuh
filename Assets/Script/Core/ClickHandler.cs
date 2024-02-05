using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ClickHandler : MonoBehaviour
{ 
    [SerializeField] private TextMeshProUGUI counterText;

    private void Start()
    {
        counterText.text = "Clicks: " + GameManager.Clicks;
        Events.ClicksUpdated += OnClicksUpdated;
    }

    public void Increment()
    {
        GameManager.Clicks += GameManager.Multiplier;
        Events.ClicksUpdated?.Invoke();
        GameEventsHandler.GetInstance().CheckEnoughClicks();
    }

    private void OnClicksUpdated()
    {
        counterText.text = "Clicks: " + GameManager.Clicks;
    }

}
