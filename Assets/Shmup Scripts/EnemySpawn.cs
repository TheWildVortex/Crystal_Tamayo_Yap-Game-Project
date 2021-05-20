using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float spawnrate;
    public GameObject[] enemies;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnrate, spawnrate);
    }

    void SpawnEnemy()
    {
        Instantiate(enemies[(int)Random.Range(0, enemies.Length)], new Vector3(Random.Range(-24f,24f),65,0),Quaternion.identity);

        spawnrate -= 1;
    }
}
