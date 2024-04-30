using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField]        //private, public ������� ��ũ���ĺ� ������Ʈ�� ���� ����
    private float moveSpeed;

    
    void Update()
    {
        //float horizontalInput = Input.GetAxisRaw("Horizontal");       //Horizontal(����)�� ����
        //float verticalInput = Input.GetAxisRaw("Vertical");
        //Vector3 moveTo = new Vector3(horizontalInput, verticalInput, 0f);       //x,y��ǥ�� �Է¹��� ���� ���������� ��ü
        //transform.position += moveTo * moveSpeed * Time.deltaTime;

        //    Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
        //    if (Input.GetKey(KeyCode.LeftArrow))        //�޾ƿ� Ű ���� ���� ȭ��ǥ Ű�� ����
        //    {
        //        transform.position -= moveTo;           //�������� �̵��ϱ� ������ -����
        //    }
        //    else if (Input.GetKey(KeyCode.RightArrow))
        //    {
        //        transform.position += moveTo;           //�������� �̵��ϱ� ������ +����
        //    }

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);                     //ȭ���� ���� �ϴ��� (0.0), ���� �ϴ��� (Screen.width, Screen.height)�� ��ȯ
        float toX = Mathf.Clamp(mousePos.x, -2.35f, 2.35f);                                         //Mathf.Clamp�� Ȱ��, ���� ���� ���� value�� �ι�° ��, ����° ���� ���� ���ϰ� ����, toX ���� ����
        transform.position = new Vector3(toX, transform.position.y, transform.position.z);   //x���� ���콺�� ���� ��ġ�� �ݿ��� ����ְ�, y, z���� ���� �÷��̾� ��ġ�� ���������� ������
    }
}
