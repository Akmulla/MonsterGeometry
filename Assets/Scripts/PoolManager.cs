using UnityEngine;
using System.Collections;

public class PoolManager : MonoBehaviour
{
    public Pool brickPool;
    
    public Pool rectanglePool;

    // Use this for initialization
    void Start ()
    {
        
    }

    public Pool GetPool(string name)
    {

        switch (name)
        {
            case "brick":
                return brickPool;
            case "rectangle":
                return rectanglePool;
            default:
                return null;
        }
        
    }

}
