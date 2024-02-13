using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    Animator animator;
    [SerializeField] float upMove;
    [SerializeField] GameObject door;
    [SerializeField] float stepOffset;
    bool isDoorOpened = false;
    Vector3 newPosition;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetTrigger("ClickButton");
            StartCoroutine(nameof(OpenDoor));
            Debug.Log("Button");
        }
    }   

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
