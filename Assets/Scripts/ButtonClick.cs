using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    Animator animator;

    [Header("������ �������� �����")]
    [SerializeField] float upMove;

    [Header("������� ����������� �����")]
    [SerializeField] GameObject door;

    [Header("�������� ����� �� ����")]
    [SerializeField] float stepOffset;

    bool isDoorOpened = false;
    Vector3 newPosition;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            animator.SetTrigger("ClickButton");
            StartCoroutine(nameof(OpenDoor));
            Debug.Log("Button");
        }
    }   

    /// <summary>
    /// �������� �������� �����
    /// </summary>
    /// <returns></returns>
    IEnumerator OpenDoor()
    {
        float startY = door.transform.position.y;
        while (!isDoorOpened) 
        {
            door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y + stepOffset, door.transform.position.z);
            yield return new WaitForSeconds(0.01f);
            if (door.transform.position.y - startY >= upMove)
            {
                isDoorOpened = true;
            }
        }
    }
        
}
