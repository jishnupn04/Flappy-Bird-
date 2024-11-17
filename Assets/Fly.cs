using UnityEngine;

public class Fly : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    private bool isAlive;
    public AudioSource flapSound;
    public AudioSource collisionSound;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isAlive = true;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive)
        {
            if (flapSound != null)
            {
                flapSound.Play();
                Debug.Log("Flap sound played.");
            }
            animator.SetTrigger("FlapTrigger");
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }
        if (transform.position.y >= 5.5 || transform.position.y <= -5)
        {
            isAlive = false;
            logic.gameOver();

        }

    }
    void OnCollisionEnter2D()
    {
        isAlive = false;
        logic.gameOver();
        if (collisionSound != null)
        {
            collisionSound.Play();
            Debug.Log("collision sound played.");
        }

    }
}
