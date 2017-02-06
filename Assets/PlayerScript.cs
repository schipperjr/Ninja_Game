using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour
{



    public float speed = 0.1f;
    public Rigidbody2D bullet;
    public Vector2 position;
    public float timer;
    public GameObject LeftBullet;
    Transform firePos;
    // Use this for initialization
    void Start()
    {
        firePos = transform.FindChild("firePos");




    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A) && transform.position.x >= -8)
        {
            Vector3 position = this.transform.position;
            position.x -= speed;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.D) && transform.position.x <= 8)
        {
            Vector3 position = this.transform.position;
            position.x += speed;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.W) && transform.position.y <= 4.1)
        {
            Vector3 position = this.transform.position;
            position.y += speed;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y >= -4.1)
        {
            Vector3 position = this.transform.position;
            position.y -= speed;
            this.transform.position = position;
        }
        {
    

        }
    }
    void Fire()
    {
        Instantiate(LeftBullet, firePos.position, Quaternion.identity);
    }
}