using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ImageCanvas : MonoBehaviour
{
    public TextMeshProUGUI resultText;
    public List<Deference> buttons = new List<Deference>(); 
    public Image img1;
    public Image img2;

    public Sprite[] firstImages;
    public Sprite[] secondImages;


    public int inc = 0;
    public void ChangeImages()
    {
        if(inc < firstImages.Length)
        {
            img1.sprite = firstImages[inc];
            img2.sprite = secondImages[inc];
            ChangeTexts();
        }
       
    }

    private void ChangeTexts()
    {
        foreach(Deference d in buttons)
        {
            d.ChangeTexts();
        }
    }

    public void ShowResult(bool isTrue)
    {
        if (isTrue)
            resultText.text = "DO�RU";
        
        else
            resultText.text = "YANLI�";

    }
}
