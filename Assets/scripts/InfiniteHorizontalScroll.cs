using UnityEngine;

public class InfiniteScroll : MonoBehaviour
{
    public float scrollSpeed = 1f;
    private float _imageWidth;
    private Vector3 _startPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _startPosition = transform.position;
        _imageWidth = GetComponent<SpriteRenderer>().bounds.size.x; //Dynamically get the background width
    }

    // Update is called once per frame
    void Update()
    {
        //Scroll the background to the left
        transform.Translate(Vector3.left * scrollSpeed * Time.deltaTime);

        //Check if the background is off-screen and reset its position
        if (transform.position.x <= _startPosition.x - _imageWidth)
        {
            transform.position += Vector3.right * _imageWidth * 2;
        }

    }
}