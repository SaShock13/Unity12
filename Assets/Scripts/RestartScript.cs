using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    /// <summary>
    /// ������������� �����
    /// </summary>
    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
