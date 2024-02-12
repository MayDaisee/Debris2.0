using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Requires child objects that have Canvas - components
/// </summary>
public class PlanetaryCanvasManager : MonoBehaviour
{
    public List<Canvas> canvases;

    // Start is called before the first frame update
    void Awake()
    {
        SetActiveCanvas(null);
        if (canvases.Count == 0)
        {
            Canvas[] canvasArray = GetComponentsInChildren<Canvas>(true);
            canvases = new List<Canvas>(canvasArray);
        }
    }
    /// <summary>
    /// Feed in active canvas ( hit.gameObject.GetComponent<Canvas>() ) from raycast. If nothing found, disables all.
    /// </summary>
    /// <param name="activeCanvas"></param>
    public void SetActiveCanvas(Canvas activeCanvas)
    {
        if (activeCanvas == null)
        {
            foreach (var canvas in canvases)
            {
                canvas.enabled = false;
            }
        }
        else if (canvases.Contains(activeCanvas))
        {
            foreach (var canvas in canvases)
            {
                canvas.enabled = (canvas == activeCanvas);
                print("Canvas ON"+activeCanvas.gameObject.name);
               
            }
            
        }

    }
}