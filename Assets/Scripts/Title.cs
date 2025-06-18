using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
    public Text UIText;

    // Start is called before the first frame update
    void Start()
    {
        //int count = 1;
        //do
        //{
        //    Debug.Log($"{count}: Hi World");
        //    count++;
        //} while (count <= 10);
        //Debug.Log($"Hi World");
        UIText.text = $"Transformations";
    }
}
