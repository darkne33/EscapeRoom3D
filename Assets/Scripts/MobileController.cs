using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MobileController : MonoBehaviour
{
    [SerializeField] FloatingJoystick moveJoyStick;
    [SerializeField] FixedTouch touch;

    void Update()
    {
        var fps = GetComponent<RigidbodyFirstPersonController>();

        fps.runAxis = moveJoyStick.Direction;
        fps.mouseLook.lookAxis = touch.TouchDist;
    }
}
