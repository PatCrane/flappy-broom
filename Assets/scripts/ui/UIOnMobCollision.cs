using System;
using TMPro;
using UnityEngine;

public class UIOnMobCollision : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI gameOverText;

    [SerializeField] 
    private GameObject gameOverBtn;

    private void OnEnable() => MobCollision.OnMobCollision += UIHandleMobCollision;
    private void OnDisable() => MobCollision.OnMobCollision -= UIHandleMobCollision;

    private void UIHandleMobCollision()
    {
        gameOverText.text = "GAME OVER!";
        gameOverBtn.SetActive(true);
    }
}
