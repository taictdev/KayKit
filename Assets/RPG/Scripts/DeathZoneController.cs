using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZoneController : MonoBehaviour
{
    public GameObject vfx;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(vfx, other.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            PlayerPrefs.SetInt("Coin", 0);
            StartCoroutine("loadScene");
        }
    }

    IEnumerator loadScene()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }
}