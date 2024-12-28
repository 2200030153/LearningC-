using UnityEngine;

public class PlayerBoundary : MonoBehaviour
{
    public float minX = -10f;
    public float maxX = 10f;
    public float minY = -5f;
    public float maxY = 5f;
    public float minZ = -10f;
    public float maxZ = 10f;

    void Update()
    {
        if (transform.position.x < minX || transform.position.x > maxX ||
            transform.position.y < minY || transform.position.y > maxY ||
            transform.position.z < minZ || transform.position.z > maxZ)
        {
            Destroy(gameObject);
        }
    }
}