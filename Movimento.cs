using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public GameObject game_over;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(0.001f,0, 0);
        pulo();
        
    }

    void pulo()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up, ForceMode2D.Impulse);
            transform.position += new Vector3(0, 0.8f, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision​)
    {
        if (collision.gameObject.tag == "Wall")
        {
            this.enabled = false;
            game_over.SetActive(true);
        }
    }
    
    
}
