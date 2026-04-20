using UnityEngine;

public class SoldierLifetime : MonoBehaviour
{
    private float lifetime;
    private bool isInitialized = false;

    public void SetLifetime(float time)
    {
        lifetime = time;
        isInitialized = true;
    }

    private void Update()
    {
        if (!isInitialized) return;

        lifetime -= Time.deltaTime;
        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
