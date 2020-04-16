using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteUp : MonoBehaviour
{
    [SerializeField] private string myMessage;
    [SerializeField] private GameObject panelNote;

    public void TakeNote()
    {
        panelNote.SetActive(true);
        FindObjectOfType<TextAnimation>().Show(myMessage);
        gameObject.SetActive(false);
    }
}
