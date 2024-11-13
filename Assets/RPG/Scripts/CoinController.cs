using UnityEngine;

public class CoinController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"OnTriggerEnter {other.name}");
        if (other.CompareTag("Player"))
        {
            int coin = PlayerPrefs.GetInt("Coin", 0);
            coin++;
            PlayerPrefs.SetInt("Coin", coin);
            Debug.Log($"Coin {coin}");
            
            Destroy(gameObject);
        }
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Coin", 0);
    }
}