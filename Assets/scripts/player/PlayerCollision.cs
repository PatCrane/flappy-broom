using System;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField]
    Animator animator;
    AudioSource audioSource;

    private void OnEnable() => MobCollision.OnMobCollision += OnPlayerMobCollision;
    private void OnDisable() => MobCollision.OnMobCollision -= OnPlayerMobCollision;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnPlayerMobCollision()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
        animator.SetTrigger("HitTrigger");
    }

}
