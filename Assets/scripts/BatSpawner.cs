using UnityEngine;

public class BatSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _batPrefab;

    [SerializeField]
    private float _spawnInterval = 2f;

    [SerializeField]
    private Camera _mainCamera;

    [SerializeField]
    private bool _isSpawningBats = false;

    void Start()
    {
        _mainCamera = Camera.main;
        InvokeRepeating(nameof(SpawnBats), 1f, _spawnInterval);
    }

    void Update()
    {
            
    }

    void SpawnBats()
    {
        float yMin = _mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y;
        float yMax = _mainCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;
        float randomY = Random.Range(yMin, yMax);

        float spawnX = _mainCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x + 1f; // just off-screen
        Vector3 spawnPosition = new Vector3(spawnX, randomY, 0);

        Instantiate(_batPrefab, spawnPosition, Quaternion.identity);
    }
}
