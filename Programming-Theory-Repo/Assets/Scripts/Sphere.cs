using UnityEngine;

public class Sphere : Shape
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    override public float Area()
    {
        float radius = transform.localScale.x / 2;

        return 4.0f * Mathf.PI * radius * radius;
    }

    override public float Volume()
    {
        float radius = transform.localScale.x / 2;

        return 4.0f / 3.0f * Mathf.PI * radius * radius * radius;
    }
}
