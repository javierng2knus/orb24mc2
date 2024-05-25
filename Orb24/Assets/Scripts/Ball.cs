using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
    public TMP_Text p1Score;
    public TMP_Text p2Score;

    public int score1 = 0;
    public int score2 = 0;

    public float speed;
    public float maxSpeed;
    public Vector2 direction;
    public float startingSpeed;
    public Vector3 startingPosition;

    // Start is called before the first frame update
    void Start()
    {
        RandomDirection();
        startingPosition = transform.position;
        startingSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D col) {

        speed *= 1.1f;
        speed = Mathf.Clamp(speed, 3, maxSpeed);

        if (col.gameObject.tag == "Wall") {
            direction = new Vector2(direction.x * Random.Range(1.0f, 1.25f), -direction.y).normalized;
        } else if (col.gameObject.tag == "DeadZone") {
            if (col.gameObject.name == "Deadzone1") {
                score2++;
                p2Score.GetComponent<TextMeshProUGUI>().text = score2.ToString();
            } else if (col.gameObject.name == "Deadzone2") {
                score1++;
                p1Score.GetComponent<TextMeshProUGUI>().text = score1.ToString();
            }
            ResetBall();
        } else {
            direction = new Vector2(-direction.x, direction.y * Random.Range(1.0f, 1.25f)).normalized;
        }
    }

    void RandomDirection() {
        float x = Random.Range(-1.0f, 1.0f);
        float y = Random.Range(-1.0f, 1.0f);
        direction = new Vector2(x, y).normalized;
    }

    void ResetBall() {
        speed = startingSpeed;
        transform.position = startingPosition;
        RandomDirection();
    }
}
