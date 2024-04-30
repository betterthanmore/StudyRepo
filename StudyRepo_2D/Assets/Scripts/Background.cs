using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 3f;  //flaot ������ moveSpeed ������ �޾ƿ�, private�� ���� �ٸ� Ŭ���������� �Ժη� ���� �� ���� �Ұ��ϰ� ��

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // �����Ӹ��� ����ؼ� ������Ʈ �� ����
    void Update()
    {
        transform.position += Vector3.down * moveSpeed * Time.deltaTime;    //Time.deltaTime�� ���� ��ǻ�� �� ���� ���̿� ���ֹ��� �ʰ� ������Ʈ �Լ� ����
        if (transform.position.y < -10)     //y ������ ���� -10 ���Ϸ� �������� if�� ����
        {
            transform.position += new Vector3(0, 10 + 10f, 0);
        }
    }
}
