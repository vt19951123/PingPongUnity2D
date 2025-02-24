using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallHandler : MonoBehaviour {
    [SerializeField] private float ballForce = 5f;

    private Rigidbody2D rb;
    private Vector2 randDirection;
    private bool isBallPressed = false;
    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    //Update is called once per frame
    void Update() {
        if (Input.GetMouseButtonDown(0) && !isBallPressed) {
            isBallPressed = true;
            float x = Random.Range(-1f, 1f);
            float y = Random.Range(-Mathf.Abs(x), Mathf.Abs(x)); // abs(x) always greater than abs(y)
            randDirection = new Vector2(x, y); // make a direction that less than 45 degree
            rb.velocity = randDirection.normalized * ballForce;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.collider.tag == "ScoreZone") {
            rb.transform.position = Vector3.zero;
            isBallPressed = false;
            rb.velocity = Vector2.zero;
        }
    }
}
