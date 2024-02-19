using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerInput))]
public class InputManager : MonoBehaviour
{
    private Vector2 pointerPos = Vector2.zero;
    
    private bool mouseButtonPressed;
    private bool keyboardButtonPressed;
    private bool isDragging;

    private static InputManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Input Manager in the scene.");
        }
        instance = this;
    }

    public static InputManager GetInstance()
    {
        return instance;
    }

    public void OnDrag(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            isDragging = true;
        }
        else if (context.canceled)
        {
            isDragging = false;
        }
    }
    
    public bool IsDragging()
    {
        Debug.Log("is dragging");
        bool result = isDragging;
        isDragging = false;
        return result;
    }
    
    
    public void OnPointer(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            pointerPos = context.ReadValue<Vector2>();
        }
        else if (context.canceled)
        {
            pointerPos = context.ReadValue<Vector2>();
        }
    }

    public Vector2 GetPointerPos()
    {
        return pointerPos;
    }

    public void MouseButtonPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            mouseButtonPressed = true;
        }
        else if (context.canceled)
        {
            mouseButtonPressed = false;
        }
    }

    public void KeyboardButtonPressed(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            keyboardButtonPressed = true;
        }
        else if (context.canceled)
        {
            keyboardButtonPressed = false;
        }
    }

    // for any of the below 'Get' methods, if we're getting it then we're also using it,
    // which means we should set it to false so that it can't be used again until actually
    // pressed again.
    public bool GetMouseButtonPressed()
    {
        bool result = mouseButtonPressed;
        mouseButtonPressed = false;
        return result;
    }
    public bool GetKeyboardButtonPressed()
    {
        bool result = keyboardButtonPressed;
        keyboardButtonPressed = false;
        return result;
    }

}