using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorMove : MonoBehaviour
{

    public Transform cameraTransform;
    //Transform 값은 카메라 움직임에 따라 달라짐, 해당 값을 카메라한테 넘겨주기 위한 cameraTransform 변수를 선언함

    public CharacterController characterController;
    //CharacterController에 3D 오브젝트를 적용하기 위한 characterController 변수 선언

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
        //h 변수에 키보드의 좌, 우 값을 읽어온 결과를 보내줌
        float v = Input.GetAxis("Vertical");
        //v 변수에 키보드의 상, 하 값을 읽어온 결과를 보내줌

        Vector3 moveDirection = new Vector3(h, 0, v);
        //([좌,우]값 받아온 h, 0, [상,하]값 받아온 v)로 새로 Vector3로 만듦
        //해당 값을 Vector3 형식의 moveDirection 값으로 넘겨줌

        moveDirection = cameraTransform.TransformDirection(moveDirection);
        //moveDirection 값은 카메라 위치다! 말해준거임
        moveDirection *= moveSpeed;
        //최종적인 moveDirection 값은 moveDirection * moveSpeed 값을 서로 곱한것임

        if (characterController.isGrounded)     //만약, charactorController가 땅에 붙어있을 경우 아래 실행함
        {
            yVelocity = 0; //y축 움직임 값은 0이죠?

            if (Input.GetKeyDown(KeyCode.Space))
            {
                yVelocity = jumpSpeed;
            }
        }

        yVelocity += (gravity * Time.deltaTime);
        //yVelocity 값은 yVelocity + (중력값 * Time.deltaTime)
        moveDirection.y = yVelocity;
        //계산한 yVelocity 값을 moveDirection.y(y축 움직임 방향)로 넘겨줌
        characterController.Move(moveDirection * Time.deltaTime);
        //최종적으로 characterController의 움직임은 방향과 Time.deltaTime을 곱한 값이 됨







    }
}
