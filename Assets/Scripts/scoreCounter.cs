using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class scoreCounter : MonoBehaviour
{
    public Text scoreText;
    public GameObject Rocket;
    int count;
    private void Start()
    {
        count = 0;
        scoreText.text = count.ToString();
    }
    public void scoreCount()
    {
        count += 1;
        scoreText.text = count.ToString();
    }
    public void Pouse()
    {

    }
}
