using UnityEngine;

public class Animationspeed : MonoBehaviour
{
    public Animator animator;
    public Renderer heartRenderer;

    [Header("Herzfrequenz")]
    public float bpm = 60f;

    void Update()
    {
        // Geschwindigkeit der Herzschlag-Animation
        animator.speed = bpm / 60f;

        // Farbe abhängig von BPM
        if (bpm < 80)
        {
            heartRenderer.material.color = Color.green;
        }
        else if (bpm < 100)
        {
            heartRenderer.material.color = Color.yellow;
        }
        else if (bpm < 130)
        {
            heartRenderer.material.color = new Color(1f, 0.5f, 0f);
        }
        else
        {
            heartRenderer.material.color = Color.red;
        }
    }
}