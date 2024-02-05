using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MultiplierBuff : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] private int multiplier;
    [SerializeField] private int price;
    [Header("UI")]
    [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI priceText;
    [SerializeField] private TextMeshProUGUI multiplierText;

    private void OnEnable()
    {
        button.onClick.AddListener(BuyMultiplierBuff);
        Events.ClicksUpdated += UpdateButtonInteractable; 
    }

    private void OnDisable()
    {
        button.onClick.RemoveListener(BuyMultiplierBuff); 
        Events.ClicksUpdated -= UpdateButtonInteractable; 
    }

    private void UpdateButtonInteractable()
    {
        button.interactable = GameManager.Clicks >= price;
    }

    private void Start()
    {
        priceText.text = price + " clicks";
        multiplierText.text = "+" + multiplier;
        UpdateButtonInteractable(); 
    }

    public void BuyMultiplierBuff()
    {
        if (GameManager.Clicks >= price)
        {
            GameManager.Multiplier += multiplier;
            GameManager.Clicks -= price;
            UpdateButtonInteractable();
            Events.ClicksUpdated?.Invoke();
        }
    }
}
