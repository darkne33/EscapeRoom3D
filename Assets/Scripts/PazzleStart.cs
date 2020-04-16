using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PazzleStart : MonoBehaviour
{
    [SerializeField] GameObject pazzle;
    [SerializeField] GameObject player;
    [SerializeField] GameObject rotationPanel;
    [SerializeField] GameObject notificationPanel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            pazzle.SetActive(true);
            rotationPanel.SetActive(false);
            notificationPanel.SetActive(false);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            pazzle.SetActive(false);
            rotationPanel.SetActive(true);
            notificationPanel.SetActive(true);
        }
    }
}
