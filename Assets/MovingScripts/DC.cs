using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DC : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();

        if (playerInventory != null )
        {
            playerInventory.DiamondCollected();
            gameObject.SetActive(false);

        }
    }
}
