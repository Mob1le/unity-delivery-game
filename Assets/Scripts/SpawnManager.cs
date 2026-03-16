using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] powerups;

    private float xRangeEnemy = 16.0f;
    private float yRangeEnemy = 1.0f;
    private float zRangeEnemy = 11.0f;

    private float xRangePowerup = 16.0f;
    private float yRangePowerup = 0.5f;
    private float zRangePowerup = 5.0f;

    private float startTimeSpawn = 1.0f;
    private float repeatTimeSpawnEnemy = 4.0f;
    private float repeatTimeSpawnPowerup = 13.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomEnemies), startTimeSpawn, repeatTimeSpawnEnemy);
        InvokeRepeating(nameof(SpawnPowerups), startTimeSpawn, repeatTimeSpawnPowerup);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomEnemies()
    {
        int randomEnemy = Random.Range(0, enemies.Length);
        float randomXPosEnemy = Random.Range(-xRangeEnemy, xRangeEnemy);
        Vector3 posEnemy = new Vector3(randomXPosEnemy, yRangeEnemy, zRangeEnemy);
        Instantiate(enemies[randomEnemy], posEnemy, enemies[randomEnemy].transform.rotation);
    }

    void SpawnPowerups()
    {
        int randomPowerup = Random.Range(0, powerups.Length);
        float randomXPosPowerup = Random.Range(-xRangePowerup, xRangePowerup);
        float randomZPosPowerup = Random.Range(-zRangePowerup, zRangePowerup);
        Vector3 posPowerup = new Vector3(randomXPosPowerup, yRangePowerup, randomZPosPowerup);
        Instantiate(powerups[randomPowerup], posPowerup, powerups[randomPowerup].transform.rotation);
    }
}
