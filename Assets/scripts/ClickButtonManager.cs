using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButtonManager : MonoBehaviour {

    public ToggleColor[] toggleColors;
    public int clickIndex = 0;
    	
	public void reset () {
        clickIndex = 0;
        for (int i = 0; i < toggleColors.Length; i++)
        {
            toggleColors[i].highlight();
        }
	}

    public void useClick() {        
        if (clickIndex < toggleColors.Length) {
            toggleColors[clickIndex].use();
        }
        clickIndex++;

        if (clickIndex > toggleColors.Length) {            
            reset();
        }
    }

    public void decrementClick () {  
        clickIndex--;
        if (clickIndex < 0) {
            clickIndex = 0;
        }

        for (int i = clickIndex; i < toggleColors.Length; i++)
        {
            toggleColors[i].highlight();
        }
    }
}
