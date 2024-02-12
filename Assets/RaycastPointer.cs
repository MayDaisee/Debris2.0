using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RaycastPointer : MonoBehaviour
{
    public float rayDistance = 5f;
    public PlanetaryCanvasManager canvasManager;
    public bool debug = false;
    int UILayer;
    void Start()
    {
       UILayer = LayerMask.GetMask("UI");
    }
    private void FixedUpdate()
    {
        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, rayDistance, UILayer))
        {
            if (debug)
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                Debug.Log("Hit Object");
            }
            
            Canvas canvas = hit.collider.gameObject.GetComponent<Canvas>();
            canvasManager.SetActiveCanvas(canvas);
            if (debug) Debug.Log("  --> hit canvas!");
        }
        else
        {
            if (debug)
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * rayDistance, Color.white);
                Debug.Log("Did not Hit Canvas");
            }
            canvasManager.SetActiveCanvas(null);
        }
    }
}