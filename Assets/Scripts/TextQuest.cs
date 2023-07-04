using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    #region Variables

    public TMP_Text AnswerText;
    public TMP_Text DescriptionText;
    public TMP_Text LocationNameText;
    public TMP_Text InstructionsText;
    
    //public Image BackgroundSprite;
    public Image LevelSprite;

    public Level StartLevel;

    private Level _currentLevel;

    private readonly KeyCode[] _inputKeys =
    {
        KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3,
        KeyCode.Alpha4, KeyCode.Alpha5, KeyCode.Alpha6,
        KeyCode.Alpha7, KeyCode.Alpha8, KeyCode.Alpha9,
    };

    #endregion

    #region Unity lifecycle

    private void Start()
    {
        // DescriptionText.text = StartLevel.Description;
        // AnswerText.text = StartLevel.Answers;
        _currentLevel = StartLevel;
        UpdateUi();
    }

    private void Update()
    {
        for (int i = 0; i < _inputKeys.Length; i++)
        {
            if (IsNextLevelExist(i) && Input.GetKeyDown(_inputKeys[i]))
            {
                _currentLevel = GetNextLevel(i);
                UpdateUi();
            }
        }
        // if (IsNextLevelExist(0) && Input.GetKeyDown(KeyCode.Alpha1))
        // {
        //     _currentLevel = GetNextLevel(0);
        //     UpdateUi();
        // }
        // else if (IsNextLevelExist(1) && Input.GetKeyDown(KeyCode.Alpha2))
        // {
        //     _currentLevel = GetNextLevel(1);
        //     UpdateUi();
        // }
        // else if (IsNextLevelExist(2) && Input.GetKeyDown(KeyCode.Alpha3))
        // {
        //     _currentLevel = GetNextLevel(2);
        //     UpdateUi();
        // }
        // else if (IsNextLevelExist(3) && Input.GetKeyDown(KeyCode.Alpha4))
        // {
        //     _currentLevel = GetNextLevel(3);
        //     UpdateUi();
        // } на память :)
    }

    #endregion

    #region Private methods

    private Level GetNextLevel(int index)
    {
        return _currentLevel.NextLevels[index];
    }

    private bool IsNextLevelExist(int index)
    {
        return _currentLevel.NextLevels.Length > index;
    }

    private void UpdateUi()
    {
        AnswerText.text = _currentLevel.Answers;
        DescriptionText.text = _currentLevel.Description;
        LocationNameText.text = _currentLevel.LocationName;
        InstructionsText.text = _currentLevel.Instructions;
        LevelSprite.sprite = _currentLevel.Sprite;
    }

    #endregion
}