using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [SerializeField] float timeStart = 1000f;
    [SerializeField] Text timer;
    [SerializeField] GameObject endImage;
    void Start()
    {
        timer.text = timeStart.ToString();
    }

    void Update()
    {
        timeStart -= Time.deltaTime;
        timer.text = Mathf.Round(timeStart).ToString();
        if (timeStart <= 0)
        {
            timeStart = 0f;
            timer.text = "0";
            endImage.SetActive(true);
        }
    }
}
