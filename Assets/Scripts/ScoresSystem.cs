using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoresSystem : MonoBehaviour {
    [SerializeField] private TMP_Text textScore;
    [SerializeField] private GameObject restartScreen;
    [SerializeField] private GameObject winnerText;

    private int score = 0;
    // Start is called before the first frame update
    void Start() {
        score = 0;

    }

    // Update is called once per frame
    void Update() {

    }

    private void OnCollisionEnter2D(Collision2D collision) {
        score++;
        textScore.text = score.ToString();

        if (score >= 2) {
            collision.gameObject.SetActive(false);
            restartScreen.SetActive(true);
            if (gameObject.transform.position.x < 0) {
                winnerText.GetComponent<TMP_Text>().text = "Player 2 Win";
            }
            else {
                winnerText.GetComponent<TMP_Text>().text = "Player 1 Win";
            }
            winnerText.SetActive(true);
        }
    }
}
