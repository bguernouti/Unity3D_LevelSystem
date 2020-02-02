using System.Collections.Generic;

[System.Serializable]
public class Level
{
    public int _Number;
    public int _Score;
    public int _MaxScore;

    private Dictionary<int,int> _AllLevels = new Level_List()._list; 

    public Level() {
        _Number = 1;
        getMaxScore(_Number);
    }

    private void getMaxScore(int level_number){
        
        _AllLevels.TryGetValue(level_number,out _MaxScore);
        _Score = 0;   
    }

    private void UpdateLevel()
    {
        _Number++;
        if (_Number >_AllLevels.Count) {
            _Number = _AllLevels.Count;
            _Score =_MaxScore;
            return;
        }
        getMaxScore(_Number);
    }

    public void UpdateScore(int ScoreToAdd){

        _Score += ScoreToAdd;
        if (_Score > _MaxScore){
            UpdateLevel();
        }
    }
}

public class Level_List
{
    public Dictionary<int,int> _list = new Dictionary<int,int>(){
        {1, 1000},
        {2, 1500},
        {3, 2000},
        {4, 2500},
        {5, 3000},
        {6, 3500},
        {7, 4000},
        {8, 4500},
        {9, 5000},
        {10, 6000},
    };
}
