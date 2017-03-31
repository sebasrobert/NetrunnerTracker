using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleColor : MonoBehaviour {

    private bool highlighted = true;

    public void toggle()
    {
        highlighted = !highlighted;
        if (highlighted) {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, 0.8f);
        } else {
            GetComponent<Image>().color = new Color(GetComponent<Image>().color.r, GetComponent<Image>().color.g, GetComponent<Image>().color.b, 0.3f);
        }
    }

    public void highlight() {
        highlighted = false;
        toggle();
    }

    public void use() {
        highlighted = true;
        toggle();
    }
}
