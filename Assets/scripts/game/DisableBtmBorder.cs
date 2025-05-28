using UnityEngine;

public class DisableBtmBorder : MonoBehaviour
{
    [SerializeField]
    private BoxCollider2D borderCollider;

    //Event subscriptions
    private void OnEnable() => StateManager.OnGameOver += DisableBorderCollider;
    private void OnDisable() => StateManager.OnGameOver -= DisableBorderCollider;

    private void DisableBorderCollider()
    {
        if (borderCollider.enabled)
        {
            borderCollider.enabled = false;
        }
    }
}
