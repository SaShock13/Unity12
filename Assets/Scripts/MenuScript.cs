using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    [SerializeField] GameObject levelSelectPanel;
    [SerializeField] GameObject menuPanel;
    [SerializeField] GameObject ball;

    public void PlayButtonClick()
    {
        levelSelectPanel.SetActive(true);
        menuPanel.SetActive(false);
        ball.SetActive(false);
    }

    public void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
