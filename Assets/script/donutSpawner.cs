 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donutSpawner : MonoBehaviour
{
    float CreatTime = 0; // ������Ʈ ���� �ֱ� Ȯ���ϱ� ���� �ð�
    float TotalTime = 0; // �� ��� �ð��� �����ϴ� ����
    float Next;

    int Phase = 1; //��������

    public GameObject nomaldonut;

    void Start()
    {
        Next = Random.Range(0.5f, 1.5f); 
        // ó�� ���� �� ������ �ð� ���� ��� �� ������Ʈ ����
    }

    void Update()
    {
        //�����Ӵ� ��� �ð� ������
        TotalTime += Time.deltaTime;
        CreatTime += Time.deltaTime;

        // ���� �ð��� ������ ������Ʈ ����
        if (CreatTime > Next)
        {
            CreatTime = 0; //���� �ð��� �ʱ�ȭ
            Next = Random.Range(0.2f, 1f);

            // Phase�� ���� ���� ���� ������Ʈ�� ����
            for (int i = 0; i < Phase; i++)
            {
                creatdonut(8f + i * 0.2f);

            }

        }
    }

    private void creatdonut(float y)
    {
        float x = Random.Range(-4f, 4f);
        createObject(nomaldonut, new Vector3(x, y, 0), Quaternion.identity);
    }


    private GameObject createObject(GameObject original, Vector3 position, Quaternion rotation)
    {
        return (GameObject)Instantiate(original, position, rotation);
    }
}
