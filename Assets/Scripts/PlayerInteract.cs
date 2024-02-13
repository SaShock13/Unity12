using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{   

    private void OnCollisionEnter(Collision collision)
    {       
        if (collision.gameObject.tag=="Obstacle")
        {
            RestartLevel();
        }        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Finish")
        {
            Finish();
        }
        if (other.gameObject.tag == "Death")
        {
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(7);
    }

    void RestartLevel()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
    }

    void Finish()
    {
        int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextIndex<=6)
        {
            SceneManager.LoadScene(nextIndex);
        }
        else 
        {
            SceneManager.LoadScene(8);
        }
    }
}
