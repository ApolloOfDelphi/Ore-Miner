using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumBalls : MonoBehaviour
{
    [Header("Dynamic")]
    public int numBalls = 0;
    private Text uiText;
    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = numBalls.ToString("Number of balls: ,#,0");
    }
}
