using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI.Table;

public class BillboardFX : MonoBehaviour
{
    public Transform camTransform;

  

    void Update()
    {
        transform.LookAt(camTransform.position);
    }
}