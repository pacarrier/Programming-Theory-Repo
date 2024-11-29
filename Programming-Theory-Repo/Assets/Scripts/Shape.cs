using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 50f;

    [SerializeField] private float scaleFactor = 1f;
    public float ScaleFactor
    {
        get { return scaleFactor; }
        set
        {
            if (value < 0.25 || value > 4)
            {
                Debug.LogWarning("Scale factor must be between 0.25 and 4");
                return;
            }
            scaleFactor = value;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate shape around the global y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
        transform.localScale = new Vector3(scaleFactor, scaleFactor, scaleFactor);
    }
    
    public abstract float Area();

    public abstract float Volume();
}
