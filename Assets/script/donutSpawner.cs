 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donutSpawner : MonoBehaviour
{
    float CreatTime = 0; // 오브젝트 생성 주기 확인하기 위한 시간
    float TotalTime = 0; // 총 경과 시간을 측정하는 변수
    float Next;

    int Phase = 1; //생성갯수

    public GameObject nomaldonut;

    void Start()
    {
        Next = Random.Range(0.5f, 1.5f); 
        // 처음 시작 시 랜덤한 시간 동안 대기 후 오브젝트 생성
    }

    void Update()
    {
        //프레임당 경과 시간 더해줌
        TotalTime += Time.deltaTime;
        CreatTime += Time.deltaTime;

        // 일정 시간이 지나면 오브젝트 생성
        if (CreatTime > Next)
        {
            CreatTime = 0; //생성 시간을 초기화
            Next = Random.Range(0.2f, 1f);

            // Phase에 따라 여러 개의 오브젝트를 생성
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
