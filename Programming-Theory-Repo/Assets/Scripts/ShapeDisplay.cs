using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ShapeDisplay : MonoBehaviour
{
    [SerializeField] private Slider scaleSlider;
    [SerializeField] private TextMeshProUGUI propertiesText;
    [SerializeField] private Shape shape;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scaleSlider.onValueChanged.AddListener(OnScaleSliderChanged);

        scaleSlider.value = shape.ScaleFactor;

        UpdateText();
    }

    private void UpdateText()
    {
        propertiesText.text = shape.Name + "\n" +
            "Area: " + shape.Area().ToString("f2") + "\n" +
            "Volume: " + shape.Volume().ToString("f2");
    }

    private void OnScaleSliderChanged(float scaleFactor)
    {
        shape.ScaleFactor = scaleFactor;
        UpdateText();
    }
}
