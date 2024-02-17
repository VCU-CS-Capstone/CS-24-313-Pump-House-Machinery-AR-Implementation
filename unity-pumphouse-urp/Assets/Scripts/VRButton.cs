using UnityEngine;

public class VRButton : MonoBehaviour
{
    public AnimatorController animationController; // Reference to the AnimationController script.
    private bool isAnimating = false; // Track whether the animation is currently playing.

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Two) || Input.GetMouseButtonDown(0)) 
        {
            // Toggle the animation state.
            isAnimating = !isAnimating;

            if (isAnimating)
            {
                // Start the animations through the AnimationController script.
                animationController.startAnimators();
            }
            else
            {
                // Stop the animations or reset them as needed.
                animationController.stopAnimators();
            }
        }
    }
}
