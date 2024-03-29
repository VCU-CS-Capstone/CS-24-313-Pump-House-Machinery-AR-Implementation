using UnityEngine;

public class TriggerDetection : MonoBehaviour
{
    public AnimatorController animationController; // Reference to the AnimationController script.
    private bool isAnimating = false; //When this is true the object is animating & when false the object is not animating
    // This method is called when another Collider enters the trigger collider attached to this GameObject
    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering GameObject has the tag "Hand"
        if (other.CompareTag("Hand"))
        {
            

            if (isAnimating)
            {
                if (animationController != null)
                {
                    animationController.stopAnimators();
                    isAnimating = !isAnimating;
                }
                else
                {
                    Debug.Log("Assign animation controller in hierarchy");
                }
            } else
            {
                if (animationController != null)
                {
                    animationController.startAnimators();
                    isAnimating = !isAnimating;
                }
                else
                {
                    Debug.Log("Assign animation controller in hierarchy");
                }
            }
        }
    }
}
