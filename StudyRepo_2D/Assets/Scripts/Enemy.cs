using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 10f;

    private float minY = -7f;

    [SerializeField]
    private float hp = 1f;


    public void SetMoveSpeed(float moveSpeed)
    {
        this.moveSpeed = moveSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;        
        if(transform.position.y < minY)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Weapon")
        {
            //Weapon weapon = other.gameObject.GetComponent<Weapon>();        //Weapon은 클래스 자료형, weapon은 파라미터(이름)
            var weapon = other.gameObject.GetComponent<Weapon>();
            hp -= weapon.damage;

            if(hp <= 0)
            {
                Destroy(gameObject);            //미사일에 맞은 게임오브젝트의 체력이 0 이하일 때 Destroy
            }
            Destroy(other.gameObject);          //미사일도 함께 Destroy
        }
    }


    //private void OnCollisionEnter2D(Collision2D collision)  //물리적 충돌 판정
    //{
        
    //}

}
