using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plusdonutspawner : MonoBehaviour
{
    //const float crin = 4.6f; 
    float CreatTime = 0;
    float TotalTime = 0;
    float Next;

    int Phase = 1;

    public GameObject plusdonut;
    void Start()
    {
        Next = Random.Range(4.2f, 8.4f);
    }

    void Update()
    {
        
        
        TotalTime += Time.deltaTime;
        CreatTime += Time.deltaTime;
        if (CreatTime > Next)
        {
            CreatTime = 0;
            Next = Random.Range(4.2f, 8.4f);

            

            for (int i = 0; i < Phase; i++)
            {
                creatplusdonut(8f + i * 0.2f);
              
            }

        }
    }



    private void creatplusdonut(float y)
    {
        float x = Random.Range(-4f, 4f);
        createObject(plusdonut, new Vector3(x, y, 0), Quaternion.identity);
    }

    private GameObject createObject(GameObject original, Vector3 position, Quaternion rotation)
    {
        return (GameObject)Instantiate(original, position, rotation);
    }
}
