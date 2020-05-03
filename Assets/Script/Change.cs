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

    public GameObject top;
    Vector3 pos_top;
    public GameObject bottom;
    Vector3 pos_bot;
    float Deplacement = 0.407697f;

    bool state = true;

    // Start is called before the first frame update
    void Start()
    {
        pos_top = top.transform.position;
        pos_bot = bottom.transform.position;
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
                pos_top.y -= Deplacement;
                pos_bot.y += Deplacement;
                top.transform.position = pos_top;
                bottom.transform.position = pos_bot;
                state = false;
            }else
            {
                Back.GetComponent<SpriteRenderer>().sprite = Back_old;
                Balle.GetComponent<SpriteRenderer>().sprite = Balle_old;
                pos_top.y += Deplacement;
                pos_bot.y -= Deplacement;
                top.transform.position = pos_top;
                bottom.transform.position = pos_bot;
                state = true;
            }
        }
        
    }
}
