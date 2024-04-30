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

        //    Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime, 0f, 0f);
        //    if (Input.GetKey(KeyCode.LeftArrow))        //받아온 키 값이 왼쪽 화살표 키면 실행
        //    {
        //        transform.position -= moveTo;           //좌측으로 이동하기 때문에 -해줌
        //    }
        //    else if (Input.GetKey(KeyCode.RightArrow))
        //    {
        //        transform.position += moveTo;           //우측으로 이동하기 때문에 +해줌
        //    }

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);                     //화면의 좌측 하단을 (0.0), 우측 하단을 (Screen.width, Screen.height)로 변환
        float toX = Mathf.Clamp(mousePos.x, -2.35f, 2.35f);                                         //Mathf.Clamp를 활용, 가장 좌측 값인 value가 두번째 항, 세번째 항을 넘지 못하게 설정, toX 값에 저장
        transform.position = new Vector3(toX, transform.position.y, transform.position.z);   //x값은 마우스의 현재 위치를 반영해 집어넣고, y, z값은 현재 플레이어 위치를 고정적으로 가져옴
    }
}
