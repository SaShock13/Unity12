using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    [Header("������ ������� ��� ���������")]
    [SerializeField] Rigidbody trap;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            trap.isKinematic = false;
        }
    }
}
