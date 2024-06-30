using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        // Get input for walking
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Check if the character should start walking
        bool Walk = horizontal != 0 || vertical != 0;
        animator.SetBool("Walk", Walk);

        // Trigger attack
        if (Input.GetButtonDown("Fire1"))
        {
            animator.SetTrigger("Attack");
        }
    }
}
