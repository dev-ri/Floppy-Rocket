using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeManager : MonoBehaviour
{
    public void slowDown()
    {
        Time.timeScale = 0.1f;
        Time.fixedDeltaTime = Time.timeScale * 0.02f;
    }
}
