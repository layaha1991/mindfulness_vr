using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public Button testButton;
    public Text testText;
    private int count;
    private void Start()
    {
        testButton.onClick.AddListener(() => testButtonFunction());    
    }

    private void testButtonFunction()
    {
        count++;
        testText.text = count.ToString();
    }
}

