using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollControllerD1 : MonoBehaviour
{
    MeshRenderer _renderer;
    float _scrollingSpeedX = 0.3f;
    Vector2 _currentPos = Vector2.zero;

    private void Awake() {
        _renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _currentPos.x += _scrollingSpeedX * Time.deltaTime;
        _renderer.material.mainTextureOffset = _currentPos;
    }
}
