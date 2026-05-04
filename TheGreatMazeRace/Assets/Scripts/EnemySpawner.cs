using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public GameObject enemyPrefab;
    private float spawnTimer;
    public float spawnInterval;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            spawnTimer = 0;
            SpawnEnemy();
        }

    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }
}
