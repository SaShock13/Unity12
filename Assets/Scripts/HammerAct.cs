using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerAct : MonoBehaviour
{
    [SerializeField] HingeJoint hinge;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag=="Player")
        {
            hinge.useSpring = false; 
        }
    }
}
