using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {
    public string controller = "j1";
    public float moveSpeed = 1f;
    
    [SerializeField]
    Rigidbody2D Rb2D;
    [SerializeField]
    GameObject body;
    [SerializeField]
    Transform spawn;
    

	void Update ()
    {
        if (!body.activeInHierarchy && Input.GetKeyDown(KeyCode.R))
        {
            body.transform.position = spawn.position;
            body.SetActive(true);
        }

        if (Input.GetAxis(controller + "Horizontal") > 0.1f || Input.GetAxis(controller + "Horizontal") < -0.1f)
            Rb2D.AddForce(Vector2.right * moveSpeed * Input.GetAxis(controller + "Horizontal"));
        if (Input.GetAxis(controller + "Vertical") > 0.1f || Input.GetAxis(controller + "Vertical") < -0.1f)
            Rb2D.AddForce(Vector2.up * moveSpeed * Input.GetAxis(controller + "Vertical"));

        if (controller == "j1")
        {
            if (Input.GetKey(KeyCode.W))
                Rb2D.AddForce(Vector2.up * moveSpeed * 1);
            if (Input.GetKey(KeyCode.A))
                Rb2D.AddForce(Vector2.left * moveSpeed * 1);
            if (Input.GetKey(KeyCode.S))
                Rb2D.AddForce(Vector2.down * moveSpeed * 1);
            if (Input.GetKey(KeyCode.D))
                Rb2D.AddForce(Vector2.right * moveSpeed * 1);
        }
        if (controller == "j2")
        {
            if (Input.GetKey(KeyCode.UpArrow))
                Rb2D.AddForce(Vector2.up * moveSpeed * 1);
            if (Input.GetKey(KeyCode.LeftArrow))
                Rb2D.AddForce(Vector2.left * moveSpeed * 1);
            if (Input.GetKey(KeyCode.DownArrow))
                Rb2D.AddForce(Vector2.down * moveSpeed * 1);
            if (Input.GetKey(KeyCode.RightArrow))
                Rb2D.AddForce(Vector2.right * moveSpeed * 1);
        }
    }
}
