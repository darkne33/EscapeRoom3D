using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Interactor : MonoBehaviour
{
    [SerializeField] private float interactRange;

    private InteractiveObject interactiveObject;
    private PickUp pickUp;
    private NoteUp noteUp;
    private Camera cam;
    private RaycastHit hit;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {           
            Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, interactRange);
            if (hit.transform)
            {
                interactiveObject = hit.transform.GetComponent<InteractiveObject>();
                pickUp = hit.transform.GetComponent<PickUp>();
                noteUp = hit.transform.GetComponent<NoteUp>();
            }
            if (interactiveObject)
            {
                interactiveObject.PerfomAction();

            }
            if (pickUp)
            {
                pickUp.TakeDrop();
            }
            if (noteUp)
            {
                noteUp.TakeNote();
            }
        }

    }
}
