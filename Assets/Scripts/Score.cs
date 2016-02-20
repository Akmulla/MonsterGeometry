using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class Score : MonoBehaviour
{
    public static int score;
    public Text scoreText;

    void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    public void UpdateScore(string name)
    {
        switch (name)
        {
            case "brick":
                score += 5;
                break;
            case "rectangle":
                score += 7;
                break;
        }
        scoreText.text = score.ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
