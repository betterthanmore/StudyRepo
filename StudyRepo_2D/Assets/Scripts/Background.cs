using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 3f;  //flaot 값으로 moveSpeed 변수를 받아옴, private를 통해 다른 클래스에서는 함부로 접근 및 수정 불가하게 함

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // 프레임마다 계속해서 업데이트 및 수행
    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;    //Time.deltaTime을 통해 컴퓨터 간 성능 차이에 구애받지 않고 업데이트 함수 실행
        if (transform.position.y < -10)     //y 포지션 값이 -10 이하로 떨어지면 if문 실행
        {
            transform.position += new Vector3(0, 10 + 10f, 0);
        }
    }
}
