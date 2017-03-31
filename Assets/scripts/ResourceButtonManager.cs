using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResourceButtonManager : MonoBehaviour {

    private int credits = 5;
    public Text creditsText = null;

    private int brainDamage = 0;
    public Text brainDamageText = null;

    private int tags = 0;
    public Text tagText = null;

    public void IncrementCredits()
    {
        if (creditsText != null)
        {
            ++credits;
            creditsText.text = credits.ToString();
        }
    }

    public void DecrementCredits()
    {
        if (creditsText != null)
        {
            --credits;
            if (credits < 0) {
                credits = 0;
            }
            creditsText.text = credits.ToString();
        }
    }

    public void IncrementBrainDamage()
    {
        if (brainDamageText != null)
        {
            ++brainDamage;
            brainDamageText.text = brainDamage.ToString();
        }
    }

    public void DecrementBrainDamage()
    {
        if (brainDamageText != null)
        {
            --brainDamage;
            if (brainDamage < 0) {
                brainDamage = 0;
            }
            brainDamageText.text = brainDamage.ToString();
        }
    }

    public void IncrementTags()
    {
        if (tagText != null)
        {
            ++tags;
            tagText.text = tags.ToString();
        }
    }

    public void DecrementTags()
    {
        if (tagText != null)
        {
            --tags;
            if (tags < 0) {
                tags = 0;
            }
            tagText.text = tags.ToString();
        }
    }
}
