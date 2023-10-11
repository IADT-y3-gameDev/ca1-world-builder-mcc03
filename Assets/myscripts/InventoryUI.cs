using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI diamondText;

    // Start is called before the first frame update
    void Start()
    {
        diamondText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateDiamondText(PlayerInventory playerInventory)
    {
        // sets the text to the number of diamonds in the inventory
        diamondText.text = playerInventory.NumberOfDiamonds.ToString();
    }
}

