using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerAct : MonoBehaviour
{
    [Header("������ ����� ��� ���������� �������")]
    [SerializeField] HingeJoint hinge;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            hinge.useSpring = false; 
        }
    }
}
