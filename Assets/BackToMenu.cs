using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{
    public GameObject Camera;
    public GameObject Player;
    public GameObject MainMenu;
    public GameObject Canvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            print("esc was pressed");
            Camera.SetActive(true);
            Player.SetActive(false);
            MainMenu.SetActive(true);
            Canvas.SetActive(true);
        }
    }
}
