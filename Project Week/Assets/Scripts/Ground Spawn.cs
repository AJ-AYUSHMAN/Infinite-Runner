using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawn : MonoBehaviour
{
    public GameObject groundTilePrefab;
    public Transform playerTransform;
    public float spawnDistance = 20f; // Distance at which new tiles will be spawned

    private Vector3 nextSpawnPoint;

    void Start()
    {
        // Initialize the next spawn point
        nextSpawnPoint = groundTilePrefab.transform.position;

        // Spawn initial ground tiles
        for (int i = 0; i < 5; i++)
        {
            SpawnGroundTile();
        }
    }

    void Update()
    {
        if (playerTransform.position.z > nextSpawnPoint.z - spawnDistance)
        {
            SpawnGroundTile();
        }
    }

    public void SpawnGroundTile()
    {
        GameObject newTile = Instantiate(groundTilePrefab, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = newTile.transform.GetChild(0).transform.position;
    }
}
