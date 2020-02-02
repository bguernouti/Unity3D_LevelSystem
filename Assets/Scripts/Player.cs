using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Objects")]
    public LevelObject GameLevelSystem;

    public int ScoreValue;

    private float speed = 4;

    void Update() {
        
        if (Input.GetKey(KeyCode.UpArrow)){

            transform.position += Vector3.up * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow)){

            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }

    void OnTriggerEnter(Collider other) {
        GameLevelSystem.GameLevel.UpdateScore(ScoreValue);
    }
}
