using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  // Keeps this GameObject across scenes
            GetComponent<AudioSource>().Play();  // Start the music
        }
        else
        {
            Destroy(gameObject);  // Destroy any duplicates
        }
    }
}
