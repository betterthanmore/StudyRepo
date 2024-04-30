using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField]        //private, public 상관없이 스크립쳐블 오브젝트로 관리 가능
    private float moveSpeed;

    
    void Update()
    {
        //float horizontalInput = Input.GetAxisRaw("Horizontal");       //Horizontal(수평값)을 받음
        //float verticalInput = Input.GetAxisRaw("Vertical");
        //Vector3 moveTo = new Vector3(horizontalInput, verticalInput, 0f);       //x,y좌표를 입력받은 수평 수직값으로 대체
        //transform.position += moveTo * moveSpeed * Time.deltaTime;

        Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
        if (Input.GetKey(KeyCode.LeftArrow))        //받아온 키 값이 왼쪽 화살표 키면 실행
        {
            transform.position -= moveTo;           //좌측으로 이동하기 때문에 -해줌
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += moveTo;           //우측으로 이동하기 때문에 +해줌
        }
    }
}
