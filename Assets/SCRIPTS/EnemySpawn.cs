using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private float minSpawnTime;

    [SerializeField]
    private float maxSpawnTime;

    private float timeUntillSpawn;
    // Start is called before the first frame update
    void Awake()
    {
        SetTimeUntilSpawn();
        
    }

    // Update is called once per frame
    void Update()
    {
        timeUntillSpawn -= Time.deltaTime;

        if (timeUntillSpawn <= 0) { 
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);
            SetTimeUntilSpawn();
        }
        
    }

    private void SetTimeUntilSpawn() {
        timeUntillSpawn = Random.Range(minSpawnTime, maxSpawnTime);

    }

}
