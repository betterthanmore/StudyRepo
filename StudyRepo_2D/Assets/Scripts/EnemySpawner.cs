using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;

    [SerializeField]
    private float Timer = 1.5f;

    private float[] arrPosX = { -2.2f, -1.1f, 0, 1.1f, 2.2f };        //한 개의 자료가 아닌 여러개의 자료를 한번에 관리

    // Start is called before the first frame update
    void Start()
    {
             
    }


    float moveSpeed = 5f;
    int enemyIndex = 0;
    int spawnCount = 0;
    //void SpawnEnemy(float posX, int index)
    //{
    //    Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);
    //    Instantiate(enemies[index], spawnPos, Quaternion.identity);
    //}


    void SpawnEnemy(float posX, int index, float moveSpeed)
    {
        Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);

        if(Random.Range(0, 5) == 0)             //5개 중 인덱스값보다 하나 높은 단계의 녀석으로 랜덤하게 소환
        {
            index += 1;
        }


        if(index >= enemies.Length)             //인덱스값이 최댓값인 7을 넘어갈 때 생길 오류를 대비해서, 에너미 인덱스의 최댓값인(7) enemies.Lenght보다 크거나 같아질 때, 인덱스 값은 최댓값의 -1 한 값과 같다고 해줌(일종의 방어코드)
        {
            index = enemies.Length - 1;
        }

        Instantiate(enemies[index], spawnPos, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if(1.5 < Timer)
        {
            foreach(float posX in arrPosX)
            {
               // int Index = Random.Range(0, enemies.Length);
                SpawnEnemy(posX, enemyIndex, moveSpeed);
            }
            Timer = 0;

            spawnCount += 1;
            if (spawnCount % 10 == 0)
            {
                enemyIndex += 1;
                moveSpeed += 1;
            }
        }
    }
}
