using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_Hide_model : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(ChangeImageColor);
    }
    public void ChangeImageColor()
    {
        GetComponent<Image>().color = RandomColor();
    }

    private Color RandomColor()
    {
        return new Color(
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f),
            UnityEngine.Random.Range(0f, 1f)
            );
    }
}
