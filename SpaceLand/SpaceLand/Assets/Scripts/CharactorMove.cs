using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorMove : MonoBehaviour
{

    public Transform cameraTransform;
    //Transform ���� ī�޶� �����ӿ� ���� �޶���, �ش� ���� ī�޶����� �Ѱ��ֱ� ���� cameraTransform ������ ������

    public CharacterController characterController;
    //CharacterController�� 3D ������Ʈ�� �����ϱ� ���� characterController ���� ����

    public float moveSpeed = 10f;
    public float gravity = -20f;
    public float yVelocity = 0f;
    public float jumpSpeed = 10f;

    void Start()
    {
        
    }
        
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        //h ������ Ű������ ��, �� ���� �о�� ����� ������
        float v = Input.GetAxis("Vertical");
        //v ������ Ű������ ��, �� ���� �о�� ����� ������

        Vector3 moveDirection = new Vector3(h, 0, v);
        //([��,��]�� �޾ƿ� h, 0, [��,��]�� �޾ƿ� v)�� ���� Vector3�� ����
        //�ش� ���� Vector3 ������ moveDirection ������ �Ѱ���

        moveDirection = cameraTransform.TransformDirection(moveDirection);
        //moveDirection ���� ī�޶� ��ġ��! �����ذ���
        moveDirection *= moveSpeed;
        //�������� moveDirection ���� moveDirection * moveSpeed ���� ���� ���Ѱ���

        if (characterController.isGrounded)     //����, charactorController�� ���� �پ����� ��� �Ʒ� ������
        {
            yVelocity = 0; //y�� ������ ���� 0����?

            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpSpeed;
            }
        }

        yVelocity += (gravity * Time.deltaTime);
        //yVelocity ���� yVelocity + (�߷°� * Time.deltaTime)
        moveDirection.y = yVelocity;
        //����� yVelocity ���� moveDirection.y(y�� ������ ����)�� �Ѱ���
        characterController.Move(moveDirection * Time.deltaTime);
        //���������� characterController�� �������� ����� Time.deltaTime�� ���� ���� ��







    }
}
