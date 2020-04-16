using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{

    [SerializeField] private string myMessage;
    [SerializeField] InteractiveObject myUnlockObject;
    [SerializeField] OpenReinforced unlockRenforced;

    public void TakeDrop()
    {
        FindObjectOfType<TextAnimation>().Show(myMessage);
        gameObject.SetActive(false);

        if (myUnlockObject != null)
        {
            myUnlockObject.Unlock();
            
        }
        if (unlockRenforced != null)
        {
            unlockRenforced.Unlock();
        }
    }
}
