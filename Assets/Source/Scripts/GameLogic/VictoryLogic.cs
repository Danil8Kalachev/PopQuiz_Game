using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryLogic : MonoBehaviour
{
    public const int _numberSceneMenu = 0;

    [SerializeField] private Button _backMenuButton;

    private void OnEnable() => _backMenuButton?.onClick.AddListener(OnBackMenuButton);
    private void OnDisable() => _backMenuButton?.onClick.RemoveListener(OnBackMenuButton);

    private void OnBackMenuButton() => SceneManager.LoadScene(_numberSceneMenu);
}