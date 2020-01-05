using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour
{
    public GameObject rocket;
    private void Update()
    {
        //rocket.GetComponent<SpriteRenderer>().color = Color.Lerp(new Color(255, 250, 116), new Color(255, 246, 13), Mathf.PingPong(Time.time, 1));
    }
}
