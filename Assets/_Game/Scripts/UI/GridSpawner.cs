using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject gridItemPrefab;

    [SerializeField]
    private int gridSizeX = 10;
    [SerializeField]
    private int gridSizeY = 10;

    void Start()
    {
        for (int i = 0; i < gridSizeX * gridSizeY; i++)
        {
            Instantiate(gridItemPrefab, transform);
        }    
    }
}
