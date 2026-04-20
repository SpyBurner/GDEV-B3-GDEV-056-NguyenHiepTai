using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class SoldierSpawner : MonoBehaviour
{
    [Header("Presets")]
    [SerializeField]
    private List<GridItem> gridItems;
    [SerializeField]
    private GameObject soldierPrefab;

    [Header("Spawner settings")]
    [SerializeField]
    private float initSpawnInterval = 5f;
    
    [SerializeField]
    private float spawnIntervalIncr = 0.01f;

    private float currentSpawnInterval = 0f;
    private float spawnTimer = 0f;

    private void Start()
    {
        currentSpawnInterval = initSpawnInterval;
    }

    private void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            spawnTimer = currentSpawnInterval;
            SpawnSoldier();
        }
    }

    private void SpawnSoldier()
    {
        int r = Random.Range(0, gridItems.Count - 1);

        var targetGridItem = gridItems[r];
        //Instantiate(soldierPrefab, )

    }

}
