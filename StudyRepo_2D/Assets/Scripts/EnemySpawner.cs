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

       


    //void SpawnEnemy(float posX, int index)
    //{
    //    Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);
    //    Instantiate(enemies[index], spawnPos, Quaternion.identity);
    //}


    void SpawnEnemy(float posX, int index)
    {
        Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);
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
                int index = Random.Range(0, enemies.Length);
                SpawnEnemy(posX, index);
            }
            Timer = 0;
        }
    }
}
