using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAnimation : MonoBehaviour
{

    private Text notificationText;
    private bool visibilityToggle = false;

    [SerializeField] private float visibilityTime = 2f, timeElapse = 0f;
    

    void Start()
    {
        notificationText = GetComponent<Text>();
    }


    void Update()
    {
        if (timeElapse >= visibilityTime)
        {
            ToggleVisibility(false);
            visibilityToggle = false;
        } else if (visibilityToggle)
        {
            timeElapse += Time.deltaTime;
        }
    }

    public void Show(string message)
    {
        ToggleVisibility(true);
        notificationText.text = message;
        timeElapse = 0f;
        visibilityToggle = true;
    }

    private void ToggleVisibility(bool show)
    {
        Color color = notificationText.color;
        color.a = show ? 1 : 0;
        notificationText.color = color;
    }
}
