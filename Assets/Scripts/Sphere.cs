using TMPro;
using UnityEngine;

public class Sphere : Shape
{
    public override void Display()
    {
        Debug.Log("I am a Sphere!");
        GameObject.Find("Message").GetComponent<TextMeshProUGUI>().text = "Im a S!ph Er E!";

        Renderer renderer = gameObject.GetComponent<Renderer>();
        if (renderer.material.color == Color.black) {
            renderer.material.color = Color.cyan;
            return;
        }
        renderer.material.color = Color.black;
    }
}
