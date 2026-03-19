using UnityEngine;

public class Gravifake : MonoBehaviour
{
    public Rigidbody sun;
    private Rigidbody rb;

    const float G = 0.1f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // ปิด gravity ปกติ
        rb.useGravity = false;

        // คำนวณความเร็วเริ่มต้น
        Vector3 direction = transform.position - sun.position;
        float distance = direction.magnitude;

        float speed = Mathf.Sqrt(G * sun.mass / distance);

        Vector3 tangent = Vector3.Cross(direction, Vector3.up).normalized;

        rb.velocity = tangent * speed;
    }

    void FixedUpdate()
    {
        ApplyGravity();
    }

    void ApplyGravity()
    {
        Vector3 direction = sun.position - rb.position;
        float distance = direction.magnitude;

        float force = G * (rb.mass * sun.mass) / (distance * distance);

        rb.AddForce(direction.normalized * force);
    }
}
