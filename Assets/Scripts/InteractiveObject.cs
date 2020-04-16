using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{

    [SerializeField] private Vector3 openPosition, closedPosition;

    [SerializeField] private float animationTime;

    [SerializeField] private bool isOpen = false, isLocked = false;

    [SerializeField] private MovementType movementType;

    [SerializeField] private string myMessage;


    private TextAnimation textAnim;
    private enum MovementType { Slide, Rotate};
    private Hashtable iTweenArgs;

    void Start()
    {
        textAnim = FindObjectOfType<TextAnimation>();
        iTweenArgs = iTween.Hash();
        iTweenArgs.Add("position", openPosition);
        iTweenArgs.Add("time", animationTime);
        iTweenArgs.Add("isLocal", true);
    }

    public void PerfomAction()
    {
        if (!isLocked)
        {
            if (isOpen)
            {
                iTweenArgs["position"] = closedPosition;
                iTweenArgs["rotation"] = closedPosition;
                
            }
            if (!isOpen)
            {
                iTweenArgs["position"] = openPosition;
                iTweenArgs["rotation"] = openPosition;
            }
            isOpen = !isOpen;


            switch (movementType)
            {
                case MovementType.Slide:
                    iTween.MoveTo(gameObject, iTweenArgs);
                    break;
                case MovementType.Rotate:
                    iTween.RotateTo(gameObject, iTweenArgs);
                    break;
            }
        } else
        {
            textAnim.Show(myMessage);
        }
    }

    public void Unlock()
    {
        isLocked = false;
    }
}
