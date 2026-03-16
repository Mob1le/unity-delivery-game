using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] powerups;

    private float xRangeEnemy = 16.0f;
    private float yRangeEnemy = 1.0f;
    private float zRangeEnemy = 11.0f;

    private float startTimeSpawn = 1.0f;
    private float reapeatTimeSpawn = 4.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemies", startTimeSpawn, reapeatTimeSpawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemies()
    {
        int randomEnemy = Random.Range(0, enemies.Length);
        float randomXPosEnemy = Random.Range(-xRangeEnemy, xRangeEnemy);
        Vector3 positionEnemy = new Vector3(randomXPosEnemy, yRangeEnemy, zRangeEnemy);
        Instantiate(enemies[randomEnemy], positionEnemy, enemies[randomEnemy].transform.rotation);
    }
}
