using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public const int _numberGameScene = 1;

    [SerializeField] private Button _startGameButton;
    [SerializeField] private Button _exitGameButton;

    private void OnEnable()
    {
        _startGameButton?.onClick.AddListener(OnStartGameButton);
        _exitGameButton?.onClick.AddListener(OnExitGameButton);
    }

    private void OnDisable()
    {
        _startGameButton?.onClick.RemoveListener(OnStartGameButton);
        _exitGameButton?.onClick.RemoveListener(OnExitGameButton);
    }

    private void OnStartGameButton() => SceneManager.LoadScene(_numberGameScene);

    private void OnExitGameButton() => Application.Quit();
}