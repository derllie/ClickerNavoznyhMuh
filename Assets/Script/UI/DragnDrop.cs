using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DragnDrop : MonoBehaviour
{
    private RectTransform rectTransform;
    private Canvas canvas;
    private Vector2 originalPosition;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
    }

    void Update()
    {
        if (InputManager.GetInstance().IsDragging())
        {
            originalPosition = rectTransform.anchoredPosition;
            rectTransform.SetAsLastSibling();
            
            Vector2 localPoint;
            RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, InputManager.GetInstance().GetPointerPos(), null, out localPoint);
            rectTransform.anchoredPosition = localPoint;
        }
        else
        {
            rectTransform.anchoredPosition = originalPosition;
        }
    }
}
