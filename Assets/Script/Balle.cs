using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balle : MonoBehaviour
{
    private float speed = 7;
    private Vector3 direction = Vector3.zero;
    private int scoreP1;
    private int scoreP2;
    public Text TextscoreP1;
    public Text TextscoreP2;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = Vector3.zero;
        Invoke("crea", 3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player1")
        {
            direction = new Vector3(1, (this.transform.position.y - col.transform.position.y)/col.collider.bounds.size.y, 0);
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
        else if(col.gameObject.name == "Player2")
        {
            direction = new Vector3(-1, (this.transform.position.y - col.transform.position.y) / col.collider.bounds.size.y, 0);
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
        else if(col.gameObject.name == "bottom" || col.gameObject.name == "top")
        {
            direction.y = direction.y * -1;
            GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
        else if(col.gameObject.name == "but_left" || col.gameObject.name == "but_right")
        {
            but(col.gameObject.name);
        }
        
    }

    public void but(string Marque)
    {
        if (Marque == "but_right")
        {
            scoreP1++;
            TextscoreP1.text = scoreP1.ToString();
        }
        else if (Marque == "but_left")
        {
            scoreP2++;
            TextscoreP2.text = scoreP2.ToString();
        }
        engage();
    }

    public void crea()
    {
        float random = Random.Range(0f, 2f);
        if(random < 1)
        {
            direction = new Vector3(1, Random.Range(-1f, 1f));
        }
        else
        {
            direction = new Vector3(-1, Random.Range(-1f, 1f));
        }
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }

    public void engage()
    {
        GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        this.transform.position = Vector3.zero;
        Invoke("crea", 1);
    }
}
