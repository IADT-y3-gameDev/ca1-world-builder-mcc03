using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    // this will be called when something collides with the diamond
    // checks if the collision is with the character
    private void OnTriggerEnter(Collider other) {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        // if !=null, then collision is with the character
        if (playerInventory != null) {

            playerInventory.DiamondCollected();
            // once collected, the diamond is set to inactive
            gameObject.SetActive(false);
        }
    }
}

