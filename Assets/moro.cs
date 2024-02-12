using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moro : MonoBehaviour
{
    
    public void doExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
