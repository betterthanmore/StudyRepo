using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] enemies;

    [SerializeField]
    private float Timer = 1.5f;

    private float[] arrPosX = { -2.2f, -1.1f, 0, 1.1f, 2.2f };        //�� ���� �ڷᰡ �ƴ� �������� �ڷḦ �ѹ��� ����

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

        if(Random.Range(0, 5) == 0)             //5�� �� �ε��������� �ϳ� ���� �ܰ��� �༮���� �����ϰ� ��ȯ
        {
            index += 1;
        }


        if(index >= enemies.Length)             //�ε������� �ִ��� 7�� �Ѿ �� ���� ������ ����ؼ�, ���ʹ� �ε����� �ִ���(7) enemies.Lenght���� ũ�ų� ������ ��, �ε��� ���� �ִ��� -1 �� ���� ���ٰ� ����(������ ����ڵ�)
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
