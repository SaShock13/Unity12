using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region TODO
//1.������� ��������� ������� ��� ������������ ������� �� �������� �������. 
//��� ����� �������
//��������� ���������� ������ � �������� ��������.

//2. ������� ������������� �������.
//��� ����� �������
//����� � ���������, ��� ��������� � ������� ����������� ��������� �������;
//�������, ��� ������������ � �������� ����� �������. ��� ����� ���� ����, ������� ����� �� ���� ��� ������������ ������
//��� ����������� ������, ����������� ����� ��� ������ �����������. ��� ���� ������ ��� �������, ���� � �������� ����� ������. 

//3. ������� ���� � �������, ������� �����������, ������ ���� ����� ��������� ����� (� ��������� ��������) � �������� ������� �. 
//��� ����� �������
//��������� � UI ������ ��� ����� � �������, ����� ����� �������, ��� ������.

//4. ������� ��������-������, �������, ��� ������������ � �������� ����� �������� ��� ��������� ������ ������� ����� SetActive.
//��� ����� ���� �����, ����� ��� �����������, � ����� ����� ����� ������.

//������ � ������������
//�����������������! �������� ��� ����� ������ ������������� �����������, ����� �� �������: 
//��������� �� ����������� ������ � ������� ���������;
//�������� � ����� ���������� � ����������� � ������� ������;
//������� � ������� ��������.

//������� ��� ������������  
//�������� ������ Vector3.Lerp()
//Unity Input    
//Unity AddForce

//��� �����������
//����������� ������� � ������������ ������ �� ���������� �������: 

//������ GetAxis;
//GetKey;
//�������� ��������;
//�������� OnTriggerEnter � OnCollisionEnter;
//������������ ����.
#endregion

public class PlayerInputController : MonoBehaviour
{    
    PlayerMoveScript playerMove;
    Vector3 vector3;
    bool isJump = false;

    private void Awake()
    {        
        playerMove = GetComponent<PlayerMoveScript>();
        vector3 = Vector3.back;
    }

    private void Update()
    {
        KeyListen();
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }
    
    /// <summary>
    /// ����������� ������� ������ , ���������� �������
    /// </summary>
    void KeyListen()
    {
        var horizontal = Input.GetAxis("Horizontal") * -1;
        var vertical = Input.GetAxis("Vertical") * -1;
        vector3 = new Vector3(horizontal, 0, vertical);
       

        if (transform.position.y <= 0.55)
        {
            isJump = false;
        }
        if (Input.GetButtonDown("Jump"))
        {
            if (isJump == false)
            {
                Debug.Log("������");
                playerMove.Jump();
                isJump = true;
            }
        }
    }

    /// <summary>
    /// �������� ����� �������� ������
    /// </summary>
    void MovePlayer()
    {
        playerMove.Move(vector3);
    }

    
}
