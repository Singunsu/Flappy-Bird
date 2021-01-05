using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMove : MonoBehaviour
{
    GameObject Go;
    public float RandomYg;
    public float RandomYg2;
    public bool check;
    public float[] O;
    public float[] D;
    birdCtrl birdCtrl;
    public GameObject BT;

    public bool BTC;
    void Start()
    {
        O = new float[4];
        O[0] = 0.04f;
        O[1] = -0.91f;
        O[2] = -1.81f;
        O[3] = -2.71f;

        D = new float[4];
        D[0] = -0.86f;
        D[1] = 0.04f;
        D[2] = 0.94f;
        D[3] = 1.89f;

        birdCtrl = GameObject.Find("Bird").GetComponent<birdCtrl>();
    }

    public void Tap()
    {
            BTC = true;
            Time.timeScale = 1;
            BT.SetActive(false);
    }

    void Update()
    {
        if (BTC == true)
        {
            if (check == true)
            {
                gameObject.transform.position = new Vector3(5.5f, -1.77f, -2);
            }
            else if (check == false)
            {
                gameObject.transform.position = new Vector3(5.5f, 1.89f, -2);
            }
            BTC = false;
        }


        if (BT.activeInHierarchy == false)
        {
            int RandomYg = Random.Range(0, 4);
            int RandomYg2 = Random.Range(0, 4);

            transform.Translate(Vector2.left * 3 * Time.deltaTime);


            if (transform.position.x < -3.6 && check == true)
            {
                gameObject.transform.position = new Vector3(5.3f, O[RandomYg], -2);
                Debug.Log(birdCtrl.score);
            }
            if (transform.position.x < -3.6 && check == false)
            {
                gameObject.transform.position = new Vector3(5.3f, D[RandomYg2], -2);
                Debug.Log(birdCtrl.score);
            }
        }

    }
}
