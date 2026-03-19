using Unity.VisualScripting;
using UnityEngine;

public class Sun : MonoBehaviour
{
    public Rigidbody sun;
    const float G = 0.1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        Vector3 direction = transform.position - sun.position;
        float distance = direction.magnitude;

        // §”π«≥§«“¡‡√Á«‚§®√
        float speed = Mathf.Sqrt(G * sun.mass / distance);

        // À“ vector µ—Èß©“°
        Vector3 tangent = Vector3.Cross(direction, Vector3.up).normalized;

        rb.velocity = tangent * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
