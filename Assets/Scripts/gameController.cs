using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public GameObject rePlayButton;
    public Animator scoreAnim;
    public GameObject bgImage;

    private void Start()
    {
        rePlayButton.SetActive(false);
        bgImage.SetActive(false);
    }
    public IEnumerator RocketDie()
    {
        rePlayButton.SetActive(true);
        bgImage.SetActive(true);

        scoreAnim.SetTrigger("endGame");
        yield return null;
    }
}
