using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Balle : MonoBehaviour
{
    private float speed = 9;
    private Vector3 direction = Vector3.zero;
    private int scoreP1;
    private int scoreP2;
    public Text TextscoreP1;
    public Text TextscoreP2;

    public AudioClip player_sound;
    public AudioClip goal_sound;
    public AudioClip wall_sound;
    AudioSource audioSource;

    public GameObject ball_1;
    public GameObject ball_2;
    


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        this.transform.position = Vector3.zero;
        Invoke("crea", 3);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward_1 = this.transform.position;
        Vector3 forward_2 = ball_1.transform.position;
        ball_1.transform.position = forward_1;
        ball_2.transform.position = forward_2;
    }

    private void traine()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Player1")
        {
            direction = new Vector3(1, (this.transform.position.y - col.transform.position.y)/col.collider.bounds.size.y, 0);
            GetComponent<Rigidbody2D>().velocity = direction * speed;
            audioSource.PlayOneShot(player_sound);
        }
        else if(col.gameObject.name == "Player2")
        {
            direction = new Vector3(-1, (this.transform.position.y - col.transform.position.y) / col.collider.bounds.size.y, 0);
            GetComponent<Rigidbody2D>().velocity = direction * speed;
            audioSource.PlayOneShot(player_sound);
        }
        else if(col.gameObject.name == "bottom" || col.gameObject.name == "top")
        {
            direction.y = direction.y * -1;
            GetComponent<Rigidbody2D>().velocity = direction * speed;
            audioSource.PlayOneShot(wall_sound);
        }
        else if(col.gameObject.name == "but_left" || col.gameObject.name == "but_right")
        {
            audioSource.PlayOneShot(goal_sound);
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
