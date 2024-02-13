using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{   
    private void OnCollisionEnter(Collision collision)
    {       
        if (collision.collider.CompareTag("Obstacle"))
        {
            RestartLevel();
        }        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            Finish();
        }
        if (other.CompareTag("Death"))
        {
            GameOver();
        }
    }

    /// <summary>
    /// Запускает сцену GameOver
    /// </summary>
    void GameOver()
    {
        SceneManager.LoadScene(7);
    }

    /// <summary>
    /// Перзапускает уровеь
    /// </summary>
    void RestartLevel()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);        
    }

    /// <summary>
    /// Переход на следующий уровень
    /// </summary>
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
