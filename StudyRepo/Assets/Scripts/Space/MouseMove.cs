using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMove : MonoBehaviour
{
    public float sensitivity = 500f;    //마우스의 민감도
    public float rotationX;             //X축의 위치
    public float rotationY;             //Y축의 위치

    void Start()
    {
        
    }

    void Update()
    {
        float mouseMoveX = Input.GetAxis("Mouse X");
        //마우스의 X축 움직임 값을 받아서 mouseMoveX 변수에 저장함
        //float mouseMoveY = Input.GetAxis("Mouse Y");
        //마우스의 Y축 움직임 값을 받아서 mouseMoveY 변수에 저장함

        rotationY += mouseMoveX * sensitivity * Time.deltaTime;
        //ratationY 변수의 값은 ratationX + (mouseMoveX * 마우스의 민감도 * Time.deltaTime)
        //rotationX += mouseMoveY * sensitivity * Time.deltaTime;
        //ratationX 변수의 값은 ratationY + (mouseMoveX * 마우스의 민감도 * Time.deltaTime)


        //아래에 실행될 if문은 마우스로 이동하는 시야가 마치 사람의 시야처럼 보이게 하기 위해서 작성

        if (rotationX > 35f)
        {
            rotationX = 35f;
            //위로 35도 이상 넘어가지 못하게 설정(고개가 너무 젖혀지면 안되니까?)
        }

        //if (rotationY > -30f)
        {
            rotationY = -30f;
            //아래로 30도 이상 넘어가지 못하게(고개가 너무 고꾸라지면 이상하잖아?)
        }

        transform.eulerAngles = new Vector3(-rotationX, 0, 0);
        //rotationX 값과 rotationY값, Z는 0을 Vector3 형식으로 변환하고, transform 오일러 각에 저장하게 됨
        //오일러각: 강체가 놓인 방향을 3차원 공간에 표시하기 위헤 도입한 세 개의 각도
    }
}
