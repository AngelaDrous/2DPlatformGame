using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelWinScreen : MonoBehaviour
{
    public string nextLevel;
    public static bool GameIsComplete = false;
    public GameObject lvlCompleteUI;

    private void Update()
    {
        if (GameIsComplete == true)
        {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                GameIsComplete = false;
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            lvlCompleteUI.SetActive(true);
            GameIsComplete = true;
            //Time.timeScale = 0f;
            //SceneManager.LoadScene("levelCompleteScreen");
        }
    }

    public void loadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        //Time.timeScale = 1f;
    }
}
