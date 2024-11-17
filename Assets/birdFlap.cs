using UnityEngine;

public class BirdWingFlap : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StartFlapping()
    {
        animator.Play("WingFlapAnimation");
    }

    public void StopFlapping()
    {
        animator.enabled = false;
    }
}
