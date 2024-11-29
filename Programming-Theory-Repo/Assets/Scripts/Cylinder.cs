using UnityEngine;

// INHERITANCE
public class Cylinder : Shape
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // POLYMORPHISM
    override public float Area()
    {
        float radius = transform.localScale.x / 2;
        float height = transform.localScale.y;

        return 2 * Mathf.PI * radius * (radius + height);
    }

    // POLYMORPHISM
    override public float Volume()
    {
        float radius = transform.localScale.x / 2;
        float height = transform.localScale.y;

        return Mathf.PI * radius * radius * height;
    }
}
