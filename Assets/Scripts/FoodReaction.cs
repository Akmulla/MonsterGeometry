using UnityEngine;
using System.Collections;

public class FoodReaction : MonoBehaviour
{
    //public string foodColor;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Monster"))
        {
            //if (other.GetComponent<MonsterReaction>().color == foodColor)
            //{
                Destroy(gameObject);
            //}
        }
    }
}
