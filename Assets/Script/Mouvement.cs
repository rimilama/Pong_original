using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    public GameObject Chara1;
    public GameObject Chara2;
    Vector3 Down;
    Vector3 Up;
    float speed_1 = 5;
    float speed_2 = 5;

    // Start is called before the first frame update
    void Start()
    {
        Down = new Vector3(0, -0.2f, 0);//Vector3(0, -0.05f, 0);
        Up = new Vector3(0, 0.2f, 0);//Vector3(0, 0.05f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("s"))
        {
            speed_1 += 1f;
            Player1.GetComponent<Rigidbody2D>().velocity = Down * speed_1;
            //Player1.transform.Translate(Down);
        }
        if (Input.GetKeyUp("s"))
        {
            speed_1 = 1;
            Player1.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        if (Input.GetKey("z"))
        {
            speed_1 += 1f;
            Player1.GetComponent<Rigidbody2D>().velocity = Up * speed_1;
            //Player1.transform.Translate(Up);
        }
        if (Input.GetKeyUp("z"))
        {
            speed_1 = 1;
            Player1.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        if (Input.GetKey("up"))
        {
            speed_2 += 1f;
            Player2.GetComponent<Rigidbody2D>().velocity = Up * speed_2;
            //Player2.transform.Translate(Up);
        }
        if (Input.GetKeyUp("up"))
        {
            speed_2 = 1;
            Player2.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        if (Input.GetKey("down"))
        {
            speed_2 += 1f;
            Player2.GetComponent<Rigidbody2D>().velocity = Down * speed_2;
            //Player2.transform.Translate(Down);
        }
        if (Input.GetKeyUp("down"))
        {
            speed_2 = 1;
            Player2.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        Chara1.transform.position = new Vector3(Chara1.transform.position.x, Player1.transform.position.y, Chara1.transform.position.z);
        Chara2.transform.position = new Vector3(Chara2.transform.position.x, Player2.transform.position.y, Chara2.transform.position.z);
    }
}
