
using UnityEngine;

public class LightsaberController : MonoBehaviour
{
    public float rotationSpeed = 100.0f;
    public Renderer saberRenderer;
    public Color defaultColor = Color.green;

    void Start()
    {
        // Set the initial color of the lightsaber blade
        if (saberRenderer != null)
        {
            saberRenderer.material.color = defaultColor;
        }
    }

    public void SetRotation(float value)
    {
        // Rotate the lightsaber based on OSC input
        transform.Rotate(Vector3.up * value * rotationSpeed * Time.deltaTime);
    }

    public void SetColor(Color color)
    {
        // Change the lightsaber color based on OSC input
        if (saberRenderer != null)
        {
            saberRenderer.material.color = color;
        }
    }
}
