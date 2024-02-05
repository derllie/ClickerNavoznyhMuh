using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class Events
{
    public static UnityAction ClicksUpdated;
    public static UnityAction<string> OnEnoughClicksMessage;
    public static UnityAction<List<string>> OnEnoughClicksDialogue;
    public static UnityAction OnEnoughClicksPopup;
    
}
