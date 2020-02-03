using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class winScreenController : MonoBehaviour {
    Image[] buttons;
    int index;
    int previousInput = 0;

    // Use this for initialization
    void Start () {
        index = 0;
        buttons = new Image[2];
        buttons[0] = GameObject.Find("Chessboxing").GetComponent<Image>();
        buttons[1] = GameObject.Find("Boxing").GetComponent<Image>();
    }
	
	// Update is called once per frame
	void Update () {
        if(SceneManager.GetActiveScene().name == "WinPlayerOne")
        {
            if (Input.GetButtonDown("A1"))
            {
                if (index == 0)
                {
                    buttons[0].color = Color.yellow;
                    SceneManager.LoadScene("MainMenu");
                }
                else if (index == 1)
                {
                    buttons[1].color = Color.black;
                    Application.Quit();
                }
            }
            if (Input.GetAxisRaw("DY1") >= 1 && previousInput == 0)
            {
                buttons[index].enabled = false;
                if (index > 0)
                    index = (index - 1) % 2;
                else
                    index = 1;
                buttons[index].enabled = true;
                previousInput = 1;
            }
            else if (Input.GetAxisRaw("DY1") <= -1 && previousInput == 0)
            {
                buttons[index].enabled = false;
                index = (index + 1) % 2;
                buttons[index].enabled = true;
                previousInput = -1;
            }
            else if (Input.GetAxisRaw("DY1") == 0)
            {
                previousInput = 0;
            }
        }
        else if (SceneManager.GetActiveScene().name == "WinPlayerTwo")
        {
            if (Input.GetButtonDown("A2"))
            {
                if (index == 0)
                {
                    SceneManager.LoadScene("MainMenu");
                }
                else if (index == 1)
                {
                    Application.Quit();
                }
            }
            if (Input.GetAxisRaw("DY2") >= 1 && previousInput == 0)
            {
                buttons[index].enabled = false;
                if (index > 0)
                    index = (index - 1) % 2;
                else
                    index = 1;
                buttons[index].enabled = true;
                previousInput = 1;
            }
            else if (Input.GetAxisRaw("DY2") <= -1 && previousInput == 0)
            {
                buttons[index].enabled = false;
                index = (index + 1) % 2;
                buttons[index].enabled = true;
                previousInput = -1;
            }
            else if (Input.GetAxisRaw("DY2") == 0)
            {
                previousInput = 0;
            }
        }
    }
}
