using TMPro;
using UnityEngine;

public class Cube : Shape
{
    public override void Display()
    {
        Debug.Log("I am a Cube!");
        GameObject.Find("Message").GetComponent<TextMeshProUGUI>().text = "I am a Cube!, Right ?";
    }
}
