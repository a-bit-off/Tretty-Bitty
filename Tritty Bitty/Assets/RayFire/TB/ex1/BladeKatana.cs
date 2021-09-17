using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeKatana : MonoBehaviour
{
	
	public Camera cam;
	Vector3 pos;
	public Transform objectToMove;

	void Update()
	{
		pos = Input.mousePosition;

		Ray ray = cam.ScreenPointToRay(pos);

		objectToMove.position = new Vector3((pos.x / 15), (pos.y / 50) - 1f, 15f);
		Debug.DrawRay(ray.origin, ray.direction * 50, Color.yellow);
	}
}
