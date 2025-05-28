using UnityEngine;

public class PlayerHandleGameOver : MonoBehaviour
{
    [SerializeField]
    PlayerController _playerController;

    private void OnEnable() => StateManager.OnGameOver += SetPlayerControllable;
    private void OnDisable() => StateManager.OnGameOver -= SetPlayerControllable;


    private void SetPlayerControllable()
    {
        _playerController._isControllable = false;
    }
}
