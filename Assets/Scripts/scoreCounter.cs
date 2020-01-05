using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class scoreCounter : MonoBehaviour
{
    public GameObject scoreText;
    public GameObject Rocket;
    int count;
    private void Start()
    {
        count = 0;
        scoreText.GetComponent<Text>().text = count.ToString();
    }
    public void scoreCount()
    {
        count += 1;
        scoreText.GetComponent<Text>().text = count.ToString();
        scoreText.GetComponent<Animator>().SetTrigger("scored");
    }
}
