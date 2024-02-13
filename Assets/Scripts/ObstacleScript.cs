using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    /// <summary>
    /// Включает рандомную анимацию препятствия
    /// </summary>
    public void ChangeAnim()
    {
        int animIndex = Random.Range(1, 6);        
        animator.SetInteger("State",animIndex);
    }
}
