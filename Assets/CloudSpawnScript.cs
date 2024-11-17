using UnityEngine;

public class CloudSpawnScript : MonoBehaviour
{
    public GameObject clouds;
    private float timer = 0;
    public float cloudCount = 10;
    public float heightOffset = 5;
    public float xOffset=10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(generateCloud), 0f, cloudCount);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < cloudCount)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            generateCloud();
            timer = 0;
        }
    }
    void generateCloud()
    {
        float lowestHeight = transform.position.y - heightOffset;
        float maximumHeight = transform.position.y + heightOffset;
        Instantiate(clouds, new Vector3(xOffset, Random.Range(lowestHeight, maximumHeight), 0), transform.rotation);

    }
}
