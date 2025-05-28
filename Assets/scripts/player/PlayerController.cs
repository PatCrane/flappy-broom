using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField]
    private float _normalFlyForce = 5f;
    
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rigidbody;
    public bool _isControllable;
  

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
       _isControllable = true;
    }

    void Update()
    {
        if (_isControllable)
        {
            FlyOnLeftClick();
            FlipOnRightClick();
        }
        
    }

    void FlyOnLeftClick()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.linearVelocity = new Vector2(_rigidbody.linearVelocityX, 0f);
            _rigidbody.AddForce(Vector2.up * _normalFlyForce, ForceMode2D.Impulse);

        }
    }


    void FlipOnRightClick()
    {
        if (Input.GetMouseButton(1)) 
        {
            _spriteRenderer.flipY = true;

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
