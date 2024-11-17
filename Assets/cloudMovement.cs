
using UnityEngine;

public class cloudMovement : MonoBehaviour
{
    public float speed;
    public float deadPoint = -14;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * speed) * Time.deltaTime;
        if (transform.position.x < deadPoint)
        {
            Debug.Log("Cloud Destroyed");
            Destroy(gameObject);
        }
    }
}
