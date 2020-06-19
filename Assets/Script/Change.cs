using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public Sprite Balle_old;
    public Sprite Balle_recent;
    public GameObject Balle;

    public Sprite Back_old;
    public Sprite Back_recent;
    public GameObject Back;

    public GameObject Chara1;
    public GameObject Chara2;

    public bool state = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            if(state == true)
            {
                Back.GetComponent<SpriteRenderer>().sprite = Back_recent;
                Balle.GetComponent<SpriteRenderer>().sprite = Balle_recent;
                Chara1.active = true;
                Chara2.active = true;
                state = false;
            }else
            {
                Back.GetComponent<SpriteRenderer>().sprite = Back_old;
                Balle.GetComponent<SpriteRenderer>().sprite = Balle_old;
                Chara1.active = false;
                Chara2.active = false;
                state = true;
            }
        }
        
    }
}
