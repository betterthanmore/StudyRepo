using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;

    private float[] arrPosX = { -2.2f, -1.1f, 0, 1.1f, 2.2f };        //�� ���� �ڷᰡ �ƴ� �������� �ڷḦ �ѹ��� ����

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
        yield return new WaitForSeconds(3f);                //�ڷ�ƾ Ȱ��, EnemyRoutine�� StartCoroutine�� ����ְ� void Start()���� ȣ��

        while(true)

        foreach (float posX in arrPosX)                      //�ݺ� ��� arrPosX
        {
            int index = Random.Range(0, enemies.Length);            //enemies.Length�� Ȱ���� �迭�� ���̸� �޾ƿ�, Random.Range�� �����ϰ� ���� �ҷ���
            SpawnEnemy(posX, index);                                //arrayPositionX�� ���� �ε��� ��
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
