using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Controller : MonoBehaviour
{
    public float speed;
    public float nspeed;
    public Vector2 Move;
    public Rigidbody2D rb;
    public float hspeed;
    public GameObject obj;
    public GameObject sp;
    public float jf;
    PhotonView view;
    public GameObject cam;
    public Controller script;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        view = GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(obj, sp.transform.position, Quaternion.identity);
        }
       

        rb.MovePosition(rb.position + Move * speed);
        Move.x = Input.GetAxis("Horizontal");
        Move.y = Input.GetAxis("Vertical");
    }
    public void Speed()
    {
        speed += hspeed;
    }
    public void stop()
    {
        speed -= hspeed;
    }
    public void create()
    {
        Instantiate(obj, sp.transform.position, Quaternion.identity);
    }
}
