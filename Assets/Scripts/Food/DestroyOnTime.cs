using UnityEngine;
using System.Collections;

public class DestroyOnTime : MonoBehaviour
{
    public float timeToDestroy;
    public PoolManager poolManager;
    private string prefabName;
    private Pool pool;

    // Use this for initialization
    void Start ()
    {
        poolManager = GameObject.Find("PoolManager").GetComponent<PoolManager>();
        prefabName = GetComponent<FoodType>().name;
        pool = poolManager.GetPool(prefabName);
        
        StartCoroutine(DestroyonTime());
	}

    IEnumerator DestroyonTime()
    {
        yield return new WaitForSeconds(timeToDestroy);
        pool.Deactivate(gameObject);
    }
}
