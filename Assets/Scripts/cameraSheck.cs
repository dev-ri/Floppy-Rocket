using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSheck : MonoBehaviour
{
    public void Shake()
    {
        GetComponent<Animator>().SetTrigger("camShake");
    }
}
