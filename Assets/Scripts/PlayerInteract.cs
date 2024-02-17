using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInteract : MonoBehaviour
{
    ParticleSystem particleSys;
    MeshRenderer meshRenderer;

    PointsCounter pointsCounter;


    private void Awake()
    {
        particleSys= GetComponentInChildren<ParticleSystem>();        
        meshRenderer = GetComponent<MeshRenderer>();
        pointsCounter = GetComponent<PointsCounter>();
        
    }

    private void OnCollisionEnter(Collision collision)
    {       
        if (collision.collider.CompareTag("Obstacle"))
        {
            
            particleSys.Play();
            meshRenderer.enabled = false;
            StartCoroutine(nameof(Restart));
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
            StartCoroutine(nameof (Restart));
        }
        if (other.CompareTag("Bonus"))
        {
            TakeBonus();
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
        if (nextIndex<=4)
        {
            SceneManager.LoadScene(nextIndex);
        }
        else 
        {
            SceneManager.LoadScene(8);
        }
    }

    void TakeBonus()
    {        
        pointsCounter.IncreasePoints();
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(1);
        RestartLevel();
    }
}
