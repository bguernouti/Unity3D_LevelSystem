using UnityEngine;

[CreateAssetMenu(menuName="Level Object")]
public class LevelObject : ScriptableObject
{
    public Level GameLevel = new Level();
}
