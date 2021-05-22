using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Insanity : MonoBehaviour
{
    private Image Bar;
    public float currentInsanity = 0f;
    public float maxInsanity = 100f;

    // Start is called before the first frame update
    void Start()
    {
        Bar = GetComponent<Image>();
    }

    public void changeInsanity(float num) //a function that will receive a number and will add/reduce it form the current insanity and will update the image after
    {
        float temp = currentInsanity; 
        while (currentInsanity < (temp + num)) {
            currentInsanity += 0.1f;
        }
        Bar.fillAmount = currentInsanity / maxInsanity;
    }
}
