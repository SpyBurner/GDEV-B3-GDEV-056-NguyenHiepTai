using UnityEditor.Analytics;
using UnityEngine;

public class GridSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject gridItemPrefab;

    [SerializeField]
    private int gridSizeX = 10;
    [SerializeField]
    private int gridSizeY = 10;

    [SerializeField]
    private GameObject playerPrefab;

    void Start()
    {
        for (int i = 0; i < gridSizeX * gridSizeY; i++)
        {
            Instantiate(gridItemPrefab, transform);
        }

        var firstChild = transform.GetChild(0);

        if (firstChild != null) {
            Instantiate(playerPrefab, firstChild);
        }

    }
}
