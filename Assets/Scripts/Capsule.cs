using TMPro;
using UnityEngine;

public class Capsule : Shape
{
    public override void Display()
    {
        Debug.Log("I am a Capsule!");

        GameObject.Find("Message").GetComponent<TextMeshProUGUI>().text = "I am a Capsule!";

        if (transform.localScale.x >= 3) {
            transform.localScale = new Vector3(1, 1, 1);
            return;
        }

        transform.localScale = new Vector3(3, 3, 3);
    }
}
