using UnityEngine;

public class Score : MonoBehaviour
{
    int score;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score = PlayerPrefs.GetInt("Score") + 1;
        PlayerPrefs.SetInt("Score", score);
    }

}
