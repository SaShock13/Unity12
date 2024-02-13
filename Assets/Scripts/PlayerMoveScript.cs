using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class PlayerMoveScript : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] int jumpForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Move(Vector3 vector3)
    {
        rb.AddForce(vector3 * speed, ForceMode.Impulse);
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}
