using UnityEngine;

// INHERITANCE
public class Cube : Shape
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // POLYMORPHISM
    override public float Area()
    {
        float side = transform.localScale.x;

        return 6 * side * side;
    }

    // POLYMORPHISM
    override public float Volume()
    {
        float side = transform.localScale.x;

        return side * side * side;
    }
}
