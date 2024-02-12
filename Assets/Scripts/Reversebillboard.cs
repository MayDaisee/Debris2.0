using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reversebillboard : MonoBehaviour
{
    public Transform cameraTransform;



    void Update()
    {
        transform.LookAt(cameraTransform.position*0.5f);
    }
}
