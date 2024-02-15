using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof (Rigidbody))]
public class PlayerMoveScript : MonoBehaviour
{
    Rigidbody rb;
    AudioSource jumpSound;

    [Header("Скорость передвижения игрока")]
    [SerializeField] float speed;

    [Header("Сила прыжка игрока")]
    [SerializeField] int jumpForce;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        jumpSound = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Придаёт силу по вектору, передаваемому в параметре
    /// </summary>
    /// <param name="vector3"></param>
    public void Move(Vector3 vector3)
    {
        rb.AddForce(vector3 * speed, ForceMode.Impulse);
    }

    /// <summary>
    /// Придает ригид боди силу , напрвленную вверх
    /// </summary>
    public void Jump()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        jumpSound.Play();
    }
}
