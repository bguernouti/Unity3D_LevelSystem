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
        int percent = (GameLevel.GameLevel._Score * 100) / GameLevel.GameLevel._MaxScore;
        LevelMax.text = percent.ToString() + " %";

        ScoreSlider.maxValue = GameLevel.GameLevel._MaxScore;
        ScoreSlider.value =  GameLevel.GameLevel._Score ;
    }
}
