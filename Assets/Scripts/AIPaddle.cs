using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIPaddle : MonoBehaviour {
    [SerializeField] private Transform ball; 
    public float speed = 5f;

    void Update() {
        if (ball != null) {
            Vector3 targetPosition = transform.position;
            targetPosition.y = Mathf.MoveTowards(transform.position.y, ball.position.y, speed * Time.deltaTime);
            transform.position = targetPosition;
        }
    }
}
