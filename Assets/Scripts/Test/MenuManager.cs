using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MonoManager : MonoBehaviour
{
    [SerializeField] private GameObject _colorselectpanel, _attackbutton;
    [SerializeField] private TextMeshProUGUI stateText;
    [SerializeField] private Button _attackButton;
    

    void Awake()
    {
        GameManager.OnGameStateChanged += GameManagerONOnGameStateChanged;
    }

    private void OnDestroy()
    {
        GameManager.OnGameStateChanged -= GameManagerONOnGameStateChanged;
    }

    private void GameManagerONOnGameStateChanged(GameState state)
    {
        _colorselectpanel.SetActive(state == GameState.SelectColor);
        _attackButton.interactable = state == GameState.PlayerTurn;
    }
        private void Start()
    {
        
    }
    public void AttackPressed()
    {
        UnitManager.instance.attack(Faction.player);

        GameManager.Instance.UpdateGamestate(GameState.EnemyTurn);
    }
}