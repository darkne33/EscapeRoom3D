using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPazzle : MonoBehaviour
{

    [SerializeField] private RectTransform[] pictures;
    [SerializeField] GameObject endDoor;
    public static bool end;

    void Start()
    {
        end = false;
    }

    void Update()
    {
        

        if (pictures[0].eulerAngles.z == 0 &&
            pictures[1].eulerAngles.z == 0 &&
            pictures[2].eulerAngles.z == 0 &&
            pictures[3].eulerAngles.z == 0 &&
            pictures[4].eulerAngles.z == 0 &&
            pictures[5].eulerAngles.z == 0 &&
            pictures[6].eulerAngles.z == 0 &&
            pictures[7].eulerAngles.z == 0 &&
            pictures[8].eulerAngles.z == 0)
        {
            end = true;
            
        }


        Debug.Log(endDoor.transform.rotation.y);

        Debug.Log(pictures[0].eulerAngles.z);
        Debug.Log(pictures[1].eulerAngles.z);
        Debug.Log(pictures[2].eulerAngles.z);
        Debug.Log(pictures[3].eulerAngles.z);
        Debug.Log(pictures[4].eulerAngles.z);
        Debug.Log(pictures[5].eulerAngles.z);
        Debug.Log(pictures[6].eulerAngles.z);
        Debug.Log(pictures[7].eulerAngles.z);
        Debug.Log(pictures[8].eulerAngles.z);
    }
}
