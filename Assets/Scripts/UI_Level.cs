using TMPro;
using UnityEngine;

public class UI_Level : MonoBehaviour
{
    public LevelObject GameLevel;

    public TextMeshProUGUI LevelScore;
    public TextMeshProUGUI LevelMax;


    void Update(){
        LevelScore.text = GameLevel.GameLevel._Number.ToString();
        LevelMax.text = GameLevel.GameLevel._Score.ToString();
    }
}
