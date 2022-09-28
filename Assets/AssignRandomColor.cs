using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class AssignRandomColor : MonoBehaviour
{
    [SerializeField] private Color[] _colors;
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _spriteRenderer.color = GetColor();
    }

    private Color GetColor()
    {
        if (_colors.Length < 0) return Color.white;

        return _colors[Random.Range(0, _colors.Length - 1)];
    }
}
