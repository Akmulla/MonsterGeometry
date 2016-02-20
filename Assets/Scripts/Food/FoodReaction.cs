using UnityEngine;
using System.Collections;

public class FoodReaction : MonoBehaviour
{
    public PoolManager poolManager;
    public Score score;
    private string prefabName;
    private Pool pool;

    void Start()
    {
        poolManager = GameObject.Find("PoolManager").GetComponent<PoolManager>();
        prefabName = GetComponent<FoodType>().name;
        pool = poolManager.GetPool(prefabName);
        score= GameObject.Find("Score").GetComponent<Score>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Monster")
        {
            pool.Deactivate(gameObject);
            score.UpdateScore(prefabName);
        }
    }
}
