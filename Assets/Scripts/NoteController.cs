using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteController : MonoBehaviour
{
    [SerializeField] GameObject noteText;

    public void OpenNote()
    {
        noteText.SetActive(true);
    }
    public void HideNote()
    {
        noteText.SetActive(false);
    }
}
