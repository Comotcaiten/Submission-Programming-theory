using TMPro;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private Color color;
    private float size;


    public Color ShapeColor
    {
        get { return color; }
        set { color = value; }
    }

    public float ShapeSize
    {
        get { return size; }
        set { size = value; }
    }

    public abstract void Display();

    private void OnMouseDown()
    {
        Display();
    }
}
