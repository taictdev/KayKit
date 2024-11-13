using UnityEngine;

public class BridgeController : MonoBehaviour
{
    private float nextTime = 2;
    private Quaternion euler;
    private float eulerY = 45;
    private float speed = 5f;

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.time > nextTime)
        {
            nextTime += 2;
            Quaternion a = transform.rotation;
            eulerY = eulerY * (-1);
            euler = Quaternion.Euler(a.x, eulerY, a.z);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, euler, speed * Time.deltaTime);
    }
}