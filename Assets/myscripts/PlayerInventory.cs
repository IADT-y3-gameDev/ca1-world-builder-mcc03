using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    // other scripts can read the value but only this one can
    // set the value
    public int NumberOfDiamonds { get; private set; }

    // event takes an argument as type PlayerInventory
    public UnityEvent<PlayerInventory> OnDiamondCollected;

    // increments the number of diamonds collected
    public void DiamondCollected()
    {
        NumberOfDiamonds++;
        OnDiamondCollected.Invoke(this);
    }
}

