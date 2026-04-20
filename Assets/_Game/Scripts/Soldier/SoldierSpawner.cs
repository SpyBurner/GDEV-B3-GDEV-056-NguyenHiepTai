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
    private float spawnIntervalDecr = 0.01f;

    [Header("Soldier Lifetime settings")]
    [SerializeField]
    private float initLifetime = 10f;
    [SerializeField]
    private float lifetimeDecrease = 0.1f;
    [SerializeField]
    private float minAllowedLifetime = 1f;

    private float currentSpawnInterval = 0f;
    private float currentLifetime;
    private float spawnTimer = 0f;

    private void Start()
    {
        currentSpawnInterval = initSpawnInterval;
        currentLifetime = initLifetime;
        spawnTimer = currentSpawnInterval;

        gridItems = new List<GridItem>(GetComponentsInChildren<GridItem>());
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
        if (gridItems == null || gridItems.Count == 0)
        {
            gridItems = new List<GridItem>(GetComponentsInChildren<GridItem>());
        }

        if (gridItems == null || gridItems.Count == 0) return;

        int r = Random.Range(0, gridItems.Count);

        var targetGridItem = gridItems[r];

        GameObject soldier = Instantiate(soldierPrefab, targetGridItem.transform);
        SoldierLifetime lifetimeScript = soldier.GetComponent<SoldierLifetime>();
        if (lifetimeScript == null)
        {
            lifetimeScript = soldier.AddComponent<SoldierLifetime>();
        }

        float lifetime = currentLifetime;
        lifetimeScript.SetLifetime(lifetime);

        currentSpawnInterval = Mathf.Max(0.1f, currentSpawnInterval - spawnIntervalDecr);

        currentLifetime = Mathf.Max(minAllowedLifetime, currentLifetime - lifetimeDecrease);
    }

}
