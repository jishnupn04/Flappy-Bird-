using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float pipeCount;
    private float timer = 0;
    public float heightOffset = 9.5F;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pipeGenerate();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < pipeCount)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            pipeGenerate();
            timer = 0;
        }
    }

    void pipeGenerate()
    {
        float lowestHeight = transform.position.y - heightOffset;
        float maximumHeight = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestHeight,maximumHeight),0), transform.rotation);


    }
}
