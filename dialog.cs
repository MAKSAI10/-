using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialog : MonoBehaviour
{
    public string[] Dialog;
    public int count;
    public TMP_Text text;




    // Start is called before the first frame update
    void Start()
    {
        count = 0;
        UptadeText();


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Next()
    {
        if (count < Dialog.Length - 1 )
        {
            count++;
            UptadeText();
        }
    }



    public void Pref()
    {
        if (count > 0)
        {
            count--;
            UptadeText();
        }
    }





    private void UptadeText()
    {
        text.text = Dialog[count];
    }



}
