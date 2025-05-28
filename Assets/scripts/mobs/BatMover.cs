using UnityEngine;

public class BatMover : MonoBehaviour
{
    [SerializeField]
    private float _speed = 5f;


    private Camera _mainCamera;
    private float _offScreenLeft;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _mainCamera = Camera.main;
        _offScreenLeft = _mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x - 1f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;

        if (transform.position.x < _offScreenLeft)
        {
            Destroy(gameObject);
        }
    }
}
