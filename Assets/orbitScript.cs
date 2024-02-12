using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orbitScript : MonoBehaviour
{
    static float globalrotation = 1f;

    public float rotateX = 0f;
    public float rotateY = 1f;
    public float rotateZ = 0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(
            rotateX * Time.deltaTime*globalrotation,
            rotateY * Time.deltaTime*globalrotation,
            rotateZ * Time.deltaTime*globalrotation)
            );
    }
}
