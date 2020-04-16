using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{

    void Update()
    {
        if (ControllerPazzle.end)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, -200, 0);
        }
    }
}
