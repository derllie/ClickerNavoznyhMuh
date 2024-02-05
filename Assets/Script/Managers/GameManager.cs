using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Clicker")] 
    public static int Clicks;
    public static int Multiplier;
    
    private void Start()
    {
        Clicks = 0;
        Multiplier = 1;
    }
}
