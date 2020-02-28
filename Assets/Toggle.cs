using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle : MonoBehaviour
{
    public Text toggleText;

    public void ToggleText()
    {
        if (toggleText.text == "true")
        {
            toggleText.text = "false";
        }
        else
        {
            toggleText.text = "true";
        }
    }
}
