using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwentyFourVertices : MonoBehaviour
{

	private void OnEnable()
	{
		var mesh = new Mesh
		{
			name = "Procedural Mesh"
		};

		mesh.vertices = new Vector3[]
		{
			new Vector3(0,0,0), new Vector3(1f,0,0), new Vector3(0,1f,0), new Vector3(1f,1f,0),
			new Vector3(1f,0,0), new Vector3(1f,0,1f), new Vector3(1f,1f,0), new Vector3(1f,1f,1f),
			new Vector3(1f,0,1f), new Vector3(0,0,1f), new Vector3(1f,1f,1f), new Vector3(0,1f,1f),
			new Vector3(0,0,1f), new Vector3(0,0,0), new Vector3(0,1f,1f), new Vector3(0,1f,0),
			new Vector3(0,1f,0), new Vector3(1f,1f,0), new Vector3(0,1f,1f), new Vector3(1f,1f,1f),
			new Vector3(0,0,0), new Vector3(1f,0,0), new Vector3(0,0,1f), new Vector3(1f,0,1f),

		};

		mesh.triangles = new int[]
		{
			0, 2, 1, //front
			1, 2, 3,

			4, 6, 5, //right
			5, 6, 7,

			8, 10, 9, //back
			9, 10, 11,

			12, 14, 13, //left
			13, 14, 15, 

			16, 18, 17, //top
			17, 18, 19,

			20, 21, 22, //Bottom
			21, 23, 22,
		};

		mesh.normals = new Vector3[]
		{
			Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back,
			Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back,
			Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back,
		};

		mesh.uv = new Vector2[] {
			Vector2.zero, Vector2.right, Vector2.up, Vector2.one,
			Vector2.zero, Vector2.right, Vector2.up, Vector2.one,
			Vector2.zero, Vector2.right, Vector2.up, Vector2.one,
			Vector2.zero, Vector2.right, Vector2.up, Vector2.one,
			Vector2.zero, Vector2.right, Vector2.up, Vector2.one,
			Vector2.zero, Vector2.right, Vector2.up, Vector2.one,
		};

		mesh.tangents = new Vector4[] {
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
			new Vector4(1f, 0f, 0f, -1f),
		};

		GetComponent<MeshFilter>().mesh = mesh;
	}
}
