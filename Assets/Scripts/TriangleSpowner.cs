using UnityEngine;
using System.Collections;

public class TriangleSpowner : MonoBehaviour
{
    public GameObject triangles;
    public float range = 2;
    public float minspowenDely = 1f;
    float posY;
    float spowenDely = 1;
    private void Start()
    {
        posY = Random.Range(range, -range);
        spowen();
    }
    private void Update()
    {
        posY = Random.Range(range, -range);
        spowenDely = Random.Range(minspowenDely, minspowenDely + 1f);
    }
    void spowen()
    {
        Instantiate(triangles, new Vector3(transform.position.x, posY, 0), Quaternion.identity);
        StartCoroutine(spowenAfter());
    }
    IEnumerator spowenAfter()
    {
        yield return new WaitForSeconds(spowenDely);
        spowen();
    }
}
