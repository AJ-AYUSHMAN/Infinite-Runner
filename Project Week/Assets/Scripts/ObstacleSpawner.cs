using System.Collections;
using System.Collections.Generic;   
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public GameObject coinPrefab;
    public Transform playerTransform;

    public float obstacleSpawnInterval = 5f; // Time interval between obstacle spawns
    public float obstacleSpawnDistance = 50f; // Distance ahead of the player to spawn obstacles
    public Vector3 obstacleSpawnOffset; // Offset to adjust the spawn position (e.g., (0, 0, spawnDistance))
    public float minX = -5f; // Minimum x position for obstacle spawn
    public float maxX = 5f;  // Maximum x position for obstacle spawn

    public float coinSpawnInterval = 1f; // Time interval between coin spawns
    public float coinSpawnChance = 0.5f; // Chance to spawn a coin (0.0 to 1.0)

    private float nextObstacleSpawnZ;
    private float nextCoinSpawnZ;

    void Start()
    {
        nextObstacleSpawnZ = playerTransform.position.z + obstacleSpawnDistance;
        nextCoinSpawnZ = playerTransform.position.z + obstacleSpawnDistance;
        StartCoroutine(SpawnEntities());
    }

    void Update()
    {
        // Check if it's time to spawn the next obstacle
        if (playerTransform.position.z + obstacleSpawnDistance >= nextObstacleSpawnZ)
        {
            SpawnObstacle();
            nextObstacleSpawnZ += obstacleSpawnInterval;
        }

        // Check if it's time to spawn the next coin
        if (playerTransform.position.z + obstacleSpawnDistance >= nextCoinSpawnZ)
        {
            StartCoroutine(SpawnCoin());
            nextCoinSpawnZ += coinSpawnInterval;
        }
    }

    IEnumerator SpawnEntities()
    {
        while (true) // Infinite loop to continually manage coin spawning
        {
            if (Random.value < coinSpawnChance)
            {
                SpawnCoin();
            }

            yield return new WaitForSeconds(0.1f); // Small delay to prevent too frequent spawning
        }
    }

    void SpawnObstacle()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(minX, maxX),
            obstacleSpawnOffset.y,
            nextObstacleSpawnZ
        );

        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }

    IEnumerator SpawnCoin()
    {
        // Wait for a short time to ensure that the obstacle has been instantiated
        yield return new WaitForSeconds(0.1f);

        Vector3 spawnPosition = new Vector3(
            Random.Range(minX, maxX),
            obstacleSpawnOffset.y + 1.5f, // Adjust the y position to be above the ground
            nextCoinSpawnZ
        );

        Instantiate(coinPrefab, spawnPosition, Quaternion.identity);
    }
}

