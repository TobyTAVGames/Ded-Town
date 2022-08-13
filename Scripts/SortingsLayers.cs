using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortingsLayers : MonoBehaviour
{
    [SerializeField] private int _sortingLayer = 0;
    [SerializeField] private int _offcet = 0;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void LateUpdate()
    {
        _renderer.sortingOrder = (int)(_sortingLayer - transform.position.y + _offcet);
    }

}
