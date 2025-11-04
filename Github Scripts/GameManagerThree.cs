using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager3 : MonoBehaviour
{

    public GameObject enemyThreePrefab;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyThree", 3, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void CreateEnemyThree()
    {
        Instantiate(enemyThreePrefab, new Vector3(Random.Range(-9f, 0f), 6.5f, 0), Quaternion.identity);
    }

}