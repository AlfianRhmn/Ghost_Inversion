using UnityEngine;

public class RendererScript : MonoBehaviour
{
    [Header("Component")]
    [SerializeField] private SpriteRenderer _rend;

    [Header("Condition")]
    [SerializeField] private bool _isBlack = false;
    private bool _isChanged = false;

    private void Start()
    {
        _rend = GetComponent<SpriteRenderer>();

        HandleInitialCondition();
    }
    private void HandleInitialCondition()
    {
        if (_isBlack)
        {
            _rend.enabled = true;
        }
        else if (!_isBlack)
        {
            _rend.enabled = false;
        }
    }

    private void Update()
    {
        HandleCondition();
    }

    private void HandleCondition()
    {
        if (_isBlack)
        {
            UpdateWhite();
        }
        else if (!_isBlack)
        {
            UpdateBlack();
        }
    }
    
    private void UpdateWhite()
    {
        if (Input.GetKeyDown(KeyCode.E) && !_isChanged)
        {
            _isChanged = true;

            _rend.enabled = false;
        }
        else if (Input.GetKeyDown(KeyCode.E) && _isChanged)
        {
            _isChanged = false;

            _rend.enabled = true;
        }
    }

    private void UpdateBlack()
    {
        if (Input.GetKeyDown(KeyCode.E) && !_isChanged)
        {
            _isChanged = true;

            _rend.enabled = true;
        }
        else if (Input.GetKeyDown(KeyCode.E) && _isChanged)
        {
            _isChanged = false;

            _rend.enabled = false;
        }
    }
}
