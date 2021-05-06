using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rgb : MonoBehaviour
{
    public Color myColor;
    [SerializeField]
    private Renderer _gameobject;
    private float red;
    private float green;
    private float blue;
    private float rgba;


    private void OnGUI()
    {
        myColor = RGBSlider(new Rect(10, 10, 200, 20), myColor);
    }

    private Color RGBSlider(Rect screenRect, Color rgb)
    {
        red = rgb.r = LabelSlider(screenRect, rgb.r, 0.0f, 1.0f, "Red");
        screenRect.y += 20;
        green = rgb.g = LabelSlider(screenRect, rgb.g, 0.0f, 1.0f, "Green");
        screenRect.y += 20;
        blue = rgb.b = LabelSlider(screenRect, rgb.b, 0.0f, 1.0f, "Blue");
        screenRect.y += 20;
        rgba = rgb.a = LabelSlider(screenRect, rgb.a, 0.0f, 1.0f, "rgbA");
        return rgb;
    }
    private float LabelSlider(Rect screenRect, float sliderValue, float sliderMinValue, float sliderMaxValue, string labelText)
    {
        GUI.Label(screenRect, labelText);
        screenRect.x += screenRect.width;
        sliderValue = GUI.HorizontalSlider(screenRect, sliderValue, sliderMinValue, sliderMaxValue);
        return sliderValue;
    }
    private void Update()
    {
        _gameobject.material.color = new Color(red, green, blue, rgba);
    }
}