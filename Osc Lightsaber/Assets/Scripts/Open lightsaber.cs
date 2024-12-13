using UnityEngine;

public class SpacebarAnimation : MonoBehaviour
{
    // Reference to the Animator component
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Animator component attached to this GameObject
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Trigger the animation
            animator.SetTrigger("Open Lightsaber");
        }
    }
}
