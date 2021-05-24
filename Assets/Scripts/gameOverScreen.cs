using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverScreen : MonoBehaviour
{
    //public string nextLevel;
    public static bool GameIsOver = false;
    public GameObject gameOverUI;

    private void Update()
    {
        if (GameIsOver == true)
        {
            gameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            gameOverUI.SetActive(false);
            Time.timeScale = 1f;
        }
        
       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            gameOverUI.SetActive(true);
            GameIsOver = true;
            //Time.timeScale = 0f;
            //SceneManager.LoadScene("levelCompleteScreen");
        }
    }




    public void tryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        gameOverUI.SetActive(false);
        GameIsOver = false;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log(("Quiting game..."));
        Application.Quit();
    }

}
