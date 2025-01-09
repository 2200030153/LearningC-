using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int totalCoins = 0; // Keeps track of the collected coins

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin")) // Check if the collided object is a coin
        {
            CollectCoin(other.gameObject);
        }
    }

    void CollectCoin(GameObject coin)
    {
        totalCoins++;
        Debug.Log($"Coins Collected: {totalCoins}");
        Destroy(coin); // Remove the coin from the scene
    }
}
