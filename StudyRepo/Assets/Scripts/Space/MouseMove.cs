using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public float sensitivity = 500f;    //���콺�� �ΰ���
    public float rotationX;             //X���� ��ġ
    public float rotationY;             //Y���� ��ġ

    void Start()
    {
        
    }

    void Update()
    {
        float mouseMoveX = Input.GetAxis("Mouse X");
        //���콺�� X�� ������ ���� �޾Ƽ� mouseMoveX ������ ������
        //float mouseMoveY = Input.GetAxis("Mouse Y");
        //���콺�� Y�� ������ ���� �޾Ƽ� mouseMoveY ������ ������

        rotationY += mouseMoveX * sensitivity * Time.deltaTime;
        //ratationY ������ ���� ratationX + (mouseMoveX * ���콺�� �ΰ��� * Time.deltaTime)
        //rotationX += mouseMoveY * sensitivity * Time.deltaTime;
        //ratationX ������ ���� ratationY + (mouseMoveX * ���콺�� �ΰ��� * Time.deltaTime)


        //�Ʒ��� ����� if���� ���콺�� �̵��ϴ� �þ߰� ��ġ ����� �þ�ó�� ���̰� �ϱ� ���ؼ� �ۼ�

        if (rotationX > 35f)
        {
            rotationX = 35f;
            //���� 35�� �̻� �Ѿ�� ���ϰ� ����(���� �ʹ� �������� �ȵǴϱ�?)
        }

        //if (rotationY > -30f)
        {
            rotationY = -30f;
            //�Ʒ��� 30�� �̻� �Ѿ�� ���ϰ�(���� �ʹ� ��ٶ����� �̻����ݾ�?)
        }

        transform.eulerAngles = new Vector3(-rotationX, 0, 0);
        //rotationX ���� rotationY��, Z�� 0�� Vector3 �������� ��ȯ�ϰ�, transform ���Ϸ� ���� �����ϰ� ��
        //���Ϸ���: ��ü�� ���� ������ 3���� ������ ǥ���ϱ� ���� ������ �� ���� ����
    }
}
