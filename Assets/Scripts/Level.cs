using UnityEngine;

public class Level : MonoBehaviour
{
    #region Variables
    
    [TextArea(5, 10)]
    public string Instructions;
    
    [TextArea(4, 6)]
    public string Answers;
    
    [TextArea(5, 15)]
    public string Description;

    [TextArea(1, 12)]
    public string LocationName;

    public Level[] NextLevels;
    public Sprite Sprite;

    #endregion
}