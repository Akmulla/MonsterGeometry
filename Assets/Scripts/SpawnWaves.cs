using UnityEngine;
using System.Collections;

public class SpawnWaves : MonoBehaviour
{
    public float startWait;

    public GameObject brick;
    public float brickRate;

    public GameObject rectangle;
    public float rectangleRate;

    private float leftEdge=-3.2f, rightEdge=3.2f;
    //private float leftEdge = -2.85f, rightEdge = 2.85f;

    void Start()
    {

        StartCoroutine(SpawnBrick());
        StartCoroutine(SpawnRectangle());
    }

    IEnumerator SpawnBrick()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            Vector2 spawnPosition = new Vector2(Random.Range(leftEdge, rightEdge), transform.position.y);
            Instantiate(brick, spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(brickRate);
        }
    }

    IEnumerator SpawnRectangle()
    {
        yield return new WaitForSeconds(startWait+5f);
        while (true)
        {
            Vector2 spawnPosition = new Vector2(Random.Range(leftEdge, rightEdge), transform.position.y);
            Instantiate(rectangle, spawnPosition, Quaternion.Euler(0f,0f,Random.Range(0f,360f)));
            yield return new WaitForSeconds(rectangleRate);
        }
    }
}
