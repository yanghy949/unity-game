using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public GameObject healthPack;
    public GameObject player;   
    public int rockNum=30;
    float time = 0;
    float time2 = 0;
    public float between = 5;
    public float between2 = 10;
    public GameObject newEnemy;
    public GameObject rock;
    void Start()
    {
        for (int i = 0; i < rockNum; i++)
        {
            newEnemy = Instantiate(rock, new Vector3(Random.Range(38,-38), Random.Range(38,-38), 0), Quaternion.identity);
            //newEnemy.GetComponent<enemy>().playerObject = player;
        }
    }


    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;
        if (time > between) 
        {
            spawner(enemy).GetComponent<enemy>().playerObject = player;
            time = 0;
        }  
        //Ñª°ü10Ãë1¸ö
        time2 += Time.deltaTime;
        if (time2 > between2) 
        {
            spawner(healthPack);
            time2 = 0;
        }       
    }
    GameObject spawner(GameObject obj) 
    {
        return Instantiate(obj, new Vector3(Random.Range(38, -38), Random.Range(38, -38), 0), Quaternion.identity);

    }
}
