using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{

    private Rigidbody2D rb;
    public int speed = 5;
    public string nextLevel = "Scene2";

    string GlobalVar = "Hello";
    int value = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Debug.Log("Hello World");
        string LocalVar = "Word";
        Debug.Log(GlobalVar + " " + LocalVar);
    }

    // Update is called once per frame
    void Update()
    {
      //  Debug.Log(value);
      //  value++;

        //  transform.position += new Vector3(0.005f, 0, 0);

        /*  if (Input.GetKeyDown(KeyCode.W))
          {
              transform.position += new Vector3(0, 1, 0);
          }
          if (Input.GetKeyDown(KeyCode.A))
          {
              transform.position += new Vector3(0, -1, 1);
          }
          if (Input.GetKeyDown(KeyCode.S))
          {
              transform.position += new Vector3(-1, -1, 0);
          }
          if (Input.GetKeyDown(KeyCode.D))
          {
              transform.position += new Vector3(0, -1, 1);
          } 
        */


        /*  if(Input.GetKeyDown(KeyCode.A))
          {
              Debug.Log("Hit");
              rb.velocity = new Vector2(-1, rb.velocity.y);
          }
          if (Input.GetKeyDown(KeyCode.D)) 
          {
              rb.velocity = new Vector2(1, rb.velocity.y);
          } 
        */

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * speed, rb.velocity.y);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        switch(collision.tag)
        {
            case "Death": 
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish": 
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
}
