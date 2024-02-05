using UnityEngine;
using UnityEngine.Events;

namespace Script.Data
{
    [System.Serializable]
    public class ClicksCountEventPair
    {
        [field:SerializeField] public int ClicksCount { get; private set; }
        [field:SerializeField] public UnityEvent Event { get; private set; }
    }
}