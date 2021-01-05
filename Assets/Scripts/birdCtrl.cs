using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class birdCtrl : MonoBehaviour
{

    // 테스트용 코드입니다.
    // Start is called before the first frame update
    Rigidbody2D rg;
    public int score;
    public Text text;
    public GameObject BT;
    public bool check;
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        
    }


    public void Tap()
    {
        if (BT.activeInHierarchy == false)
        {
            rg.velocity = Vector2.up * 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "스코어\n" + score.ToString();

        if (transform.position.x > 0 || transform.position.x < 0)
        {
            gameObject.transform.position = new Vector3(0, gameObject.transform.position.y, -3);
        }
    }
        

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.tag == "Box")
        {
            Debug.Log(collision2D.gameObject.name);
            Time.timeScale = 0;
            BT.SetActive(true);
        }
    }

    void OnTriggerExit2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.tag == "Score")
        {
            Debug.Log(score);
            score += 1;

        }
    }
}
