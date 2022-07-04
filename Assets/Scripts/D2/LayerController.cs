using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayerController : MonoBehaviour
{
    float _scrollingSpeed = 0.2f, _currentTempSpeed; 
    MeshRenderer _renderer;
    Vector2 _currentPosition = new Vector2();

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _currentTempSpeed = _scrollingSpeed * (20.42f / gameObject.transform.position.z);
        _currentPosition.x = _currentPosition.x + _scrollingSpeed * Time.deltaTime;
        _renderer.material.mainTextureOffset = _currentPosition;
    }
}
