using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenReinforced : MonoBehaviour
{
    [SerializeField] GameObject codePanel;
    [SerializeField] GameObject player;
    [SerializeField] private bool isLocked = false;
    [SerializeField] private string myMessage;

    private TextAnimation textAnim;

    void Start()
    {
        textAnim = FindObjectOfType<TextAnimation>();
        codePanel.SetActive(false);
    }


    public void OpenBox()
    {
        gameObject.transform.Rotate(0, 0, -70);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player && !isLocked)
        {
            codePanel.SetActive(true);
        }
        else
        {
            textAnim.Show(myMessage);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            codePanel.SetActive(false);
        }
    }

    public void Unlock()
    {
        isLocked = false;
    }
}
