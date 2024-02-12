using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textTrig : MonoBehaviour
{

    public Collider triggerCollider;

    public GameObject showObject;


    private void OnTriggerEnter(Collider other)
    {
        showObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        showObject.SetActive(false);
    }


}
