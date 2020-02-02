using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Level : MonoBehaviour
{
    [Header("Objects")]
    public LevelObject GameLevel;

    [Header("UI Elements")]
    public TextMeshProUGUI LevelScore;
    public TextMeshProUGUI LevelMax;
    public Slider ScoreSlider;

    private string BeforeNumber = "Lvl";

    void Update(){
        LevelScore.text = BeforeNumber + " " + GameLevel.GameLevel._Number.ToString();
        LevelMax.text = GameLevel.GameLevel._Score.ToString();

        ScoreSlider.maxValue = GameLevel.GameLevel._MaxScore;

        // float SliderValue = (float) GameLevel.GameLevel._Score / (float)GameLevel.GameLevel._MaxScore;
        ScoreSlider.value =  GameLevel.GameLevel._Score;
    }
}
