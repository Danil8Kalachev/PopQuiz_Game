using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelGame : MonoBehaviour
{
    public const int _numberLossingScene = 7;

    [SerializeField] private Button _correctAnswerButton;
    [SerializeField] private Button _wrongAnswerButtonOne;
    [SerializeField] private Button _wrongAnswerButtonTwo;

    private void OnEnable()
    {
        _correctAnswerButton?.onClick.AddListener(OnCorrectAnswerButton);
        _wrongAnswerButtonOne?.onClick.AddListener(OnWrongAnswerButton);
        _wrongAnswerButtonTwo?.onClick.AddListener(OnWrongAnswerButton);
    }

    private void OnDisable()
    {
        _correctAnswerButton?.onClick.RemoveListener(OnCorrectAnswerButton);
        _wrongAnswerButtonOne?.onClick.RemoveListener(OnWrongAnswerButton);
        _wrongAnswerButtonTwo?.onClick.RemoveListener(OnWrongAnswerButton);
    }

    private void OnCorrectAnswerButton()
    {
        int numberActiveScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(numberActiveScene + 1);
    }

    private void OnWrongAnswerButton() => SceneManager.LoadScene(_numberLossingScene);
}