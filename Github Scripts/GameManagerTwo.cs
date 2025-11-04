using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{

    public GameObject enemyTwoPrefab;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateEnemyTwo", 2, 3);
    }

    void CreateEnemyTwo()
    {
        if (player != null)
        {
            Vector3 spawnPosition = new Vector3(player.transform.position.x, 9f, 0f);
            Instantiate(enemyTwoPrefab, spawnPosition, Quaternion.identity);
        }
    }

}