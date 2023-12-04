using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManeger : MonoBehaviour
{
    public GameObject EnemyPrefab;
    private float spawnRange = 9.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnEnemyWave(3); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(EnemyPrefab, GenerateSpawnPosition(), EnemyPrefab.transform.rotation);
        }
    }
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;

    }
}
