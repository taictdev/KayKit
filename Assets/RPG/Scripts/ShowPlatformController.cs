using UnityEngine;

public class ShowPlatformController : MonoBehaviour
{
    public GameObject platform;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            platform.SetActive(true);

            transform.rotation = Quaternion.Euler(0, 0, 45);
        }
    }
}