using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float _normalFlyForce = 5f;
    //private float _boostedFlyForce = 6f;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;
    //private float _currentGravityScale; Mechanic to increase gravity on vertical flip. Not sure I want to use this rn.
    
    //public AudioSource flySound; -- Will activate once I have sound/music assets done.


    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        //_currentGravityScale = _rigidbody.gravityScale;
        _spriteRenderer = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        FlyOnLeftClick();
        FlipOnRightClick();
    }

    void FlyOnLeftClick()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.linearVelocity = new Vector2(_rigidbody.linearVelocityX, 0f);
            _rigidbody.AddForce(Vector2.up * _normalFlyForce, ForceMode2D.Impulse);
            
            //if (flapSound) flapSound.Play();
        }
    }


    void FlipOnRightClick()
    {
        if (Input.GetMouseButton(1)) // Right button is held down
        {
            _spriteRenderer.flipY = true;
            //_rigidbody.gravityScale = currentGravityScale * 2;
            //Debug.Log(_rigidbody.gravityScale);
        }
        else
        {
            _spriteRenderer.flipY = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Send mob collision event");
    }
}
