using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

public class Touch4Info : MonoBehaviour
{
    public PlanetaryCanvasManager canvasManager;
   
    private void OnTriggerEnter(Collider other)
    {
        Canvas canvas = other.gameObject.GetComponent<Canvas>();

        print("collision detected with "+other.gameObject.name);
        if(canvas != null)
        canvasManager.SetActiveCanvas(canvas);
    }
}
