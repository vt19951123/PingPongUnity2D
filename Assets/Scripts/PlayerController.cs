using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private float maxY = 3f;

    private Transform paddle1;
    private Transform paddle2;
    // Start is called before the first frame update
    void Start() {
        paddle1 = GameObject.Find("Player1").transform;
        paddle2 = GameObject.Find("Player2").transform;
    }

    // Update is called once per frame
    void Update() {
        float yInput1 = Input.GetAxisRaw("Vertical1");
        float yInput2 = Input.GetAxisRaw("Vertical2");

        paddle1.Translate(Vector3.up * yInput1 * moveSpeed * Time.deltaTime);
        paddle1.position = new Vector2(paddle1.position.x, Mathf.Clamp(paddle1.position.y, -maxY, maxY));

        paddle2.Translate(Vector3.up * yInput2 * moveSpeed * Time.deltaTime);
        paddle2.position = new Vector2(paddle2.position.x, Mathf.Clamp(paddle2.position.y, -maxY, maxY));
    }
}
