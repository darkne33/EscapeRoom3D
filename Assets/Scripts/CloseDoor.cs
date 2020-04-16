using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseDoor : MonoBehaviour
{
    [SerializeField] GameObject door;
    [SerializeField] GameObject player;
    [SerializeField] GameObject room_1;
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            door.SetActive(true);
            room_1.SetActive(false);
        }
    }
}
