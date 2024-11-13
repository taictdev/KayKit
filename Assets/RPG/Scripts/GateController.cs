using UnityEngine;

public class GateController : MonoBehaviour
{
    private bool isOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isOpen = true;
        }
    }

    private void Update()
    {
        if (isOpen == false)
        {
            return;
        }

        transform.position = Vector3.Lerp(transform.position, transform.position + Vector3.down * (2), Time.deltaTime);
    }
}