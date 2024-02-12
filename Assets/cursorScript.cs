using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cursorScript : MonoBehaviour
{
    void OnEnable()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }

    void OnDisable()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }
}
