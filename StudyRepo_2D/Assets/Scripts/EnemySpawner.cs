using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;

    private float[] arrPosX = { -2.2f, -1.1f, 0, 1.1f, 2.2f };        //한 개의 자료가 아닌 여러개의 자료를 한번에 관리

    // Start is called before the first frame update
    void Start()
    {
        StartEnemyRoutine();        
    }

    void StartEnemyRoutine()
    {
        StartCoroutine("EnemyRoutine");
    }

    IEnumerator EnemyRoutine()
    {
        yield return new WaitForSeconds(3f);                //코루틴 활용, EnemyRoutine를 StartCoroutine에 집어넣고 void Start()에서 호출

        while(true)

        foreach (float posX in arrPosX)                      //반복 대상 arrPosX
        {
            int index = Random.Range(0, enemies.Length);            //enemies.Length를 활용해 배열의 길이를 받아옴, Random.Range로 랜덤하게 값을 불러옴
            SpawnEnemy(posX, index);                                //arrayPositionX의 값과 인덱스 값
        }
    }

    void SpawnEnemy(float posX, int index)
    {
        Vector3 spawnPos = new Vector3(posX, transform.position.y, transform.position.z);
        Instantiate(enemies[index], spawnPos, Quaternion.identity);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
