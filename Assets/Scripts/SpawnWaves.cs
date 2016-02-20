using UnityEngine;
using System.Collections;

public class SpawnWaves : MonoBehaviour
{
    private PoolManager poolManager;
    [Header("Pool")]
    private Pool brickPool;
    private Pool rectanglePool;
    [Header("Wave Rates")]
    public float brickWaveRate;
    public float rectangleWaveRate;
    [Space(20)]
    public float startWait;


    void Start()
    {
        poolManager = GameObject.Find("PoolManager").GetComponent<PoolManager>();
        brickPool = poolManager.GetPool("brick");
        rectanglePool = poolManager.GetPool("rectangle");
        StartCoroutine(SpawnBrick());
        StartCoroutine(SpawnRectangle());
    }


    IEnumerator SpawnBrick()
    {
        while (true)
        {
            yield return new WaitForSeconds(startWait);
            Vector2 spawnPosition = new Vector2(Random.Range((float)Edges.leftEdge + 1.0f, (float)Edges.rightEdge - 1.0f), Edges.topEdge);
            //Instantiate(citizen, spawnPosition, Quaternion.identity);
            brickPool.Activate(spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(brickWaveRate);
        }
    }

    IEnumerator SpawnRectangle()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            Vector2 spawnPosition = new Vector2(Random.Range((float)Edges.leftEdge, (float)Edges.rightEdge), Edges.topEdge);
            //Instantiate(flameThrower, spawnPosition, Quaternion.identity);
            rectanglePool.Activate(spawnPosition, Quaternion.identity);
            yield return new WaitForSeconds(rectangleWaveRate);
        }
    }


}
