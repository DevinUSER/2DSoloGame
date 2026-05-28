using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryCanvas : MonoBehaviour
{
    [SerializeField] Canvas WinCanvas;

     void Start()
        {
            WinCanvas.enabled = false;
        }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "EndFlag")
        {
            WinCanvas.enabled = true;
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}