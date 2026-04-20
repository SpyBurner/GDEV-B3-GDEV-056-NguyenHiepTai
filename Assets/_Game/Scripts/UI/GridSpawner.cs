using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject gridItemPrefab;

    [SerializeField]
    private int gridSize = 10;

    void Start()
    {
        for (int i = 0; i < gridSize*gridSize; i++)
        {
            Instantiate(gridItemPrefab, transform);
        }    
    }
}
