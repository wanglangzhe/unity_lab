using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    [SerializeField]
	Transform pointPrefab;

    [SerializeField, Range(10, 100)]
    int resolution = 10;

    void Awake () {
        float step = 2f / resolution;
		var scale = Vector3.one * step;
        var position = Vector3.zero;
		for (int i = 0; i < resolution; i++) {
			Transform point = Instantiate(pointPrefab);
            position.x = (i + 0.5f) * step  - 1f;
            position.y = position.x;
            // point.localPosition = Vector3.right * ((i + 0.5f) / 5f - 1f);
            point.localPosition = position;
            point.localScale = scale;
        }
    }
}
