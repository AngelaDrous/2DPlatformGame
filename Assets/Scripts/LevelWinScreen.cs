using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelWinScreen : MonoBehaviour
{
    public string nextLevel;


    private void Update()
    {
        if (SceneManager.GetActiveScene().Equals("levelCompleteScreen"))
        {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(nextLevel);
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene("levelCompleteScreen");
        }
    }
}
