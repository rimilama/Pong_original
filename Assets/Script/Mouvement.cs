using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouvement : MonoBehaviour
{
    public GameObject Player1;
    public GameObject Player2;
    Vector3 Down;
    Vector3 Up;

    // Start is called before the first frame update
    void Start()
    {
        Down = new Vector3(0, -0.05f, 0);
        Up = new Vector3(0, 0.05f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("down"))
        {
            Player1.transform.Translate(Down);
        }
        if (Input.GetKey("up"))
        {
            Player1.transform.Translate(Up);
        }
        if (Input.GetKey("z"))
        {
            Player2.transform.Translate(Up);
        }
        if (Input.GetKey("s"))
        {
            Player2.transform.Translate(Down);
        }
    }
}
