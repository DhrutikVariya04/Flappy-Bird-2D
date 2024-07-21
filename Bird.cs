using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Bird : MonoBehaviour
{
    Rigidbody2D RB;
    public static bool ENDGAME = false;
    public GameObject gameover;
    public Text Myscore;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (ENDGAME) return;

        transform.position += new Vector3(0.06f, 0f, 0f);

        int currentscore = PlayerPrefs.GetInt("Score");
        Myscore.text = ""+currentscore;

        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            RB.velocity = new Vector2(0f, 5f);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ENDGAME = true;
        RB.gravityScale = 0f;
        RB.velocity = Vector3.zero;
        gameover.SetActive(true);
    }

    public void restart()
    {
        ENDGAME = false;
        transform.position = new Vector3(-1.16f, 0.0986f, 80f);
        RB.gravityScale = 0.7f;
        PlayerPrefs.SetInt("Score", 0);
        gameover.SetActive(false);
    }

}
