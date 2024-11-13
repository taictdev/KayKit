using UnityEngine;

public class PlayerGame1Controller : MonoBehaviour
{
    private Rigidbody rb;
    private float force = 5;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
       
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        rb.AddForce(new Vector3(x * force, 0, y * force));
    }
}