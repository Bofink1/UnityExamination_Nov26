using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        CoinManager.coinAmount++;
        CoinManager.bosshealth--;
        Destroy(gameObject);
        
    }
}
