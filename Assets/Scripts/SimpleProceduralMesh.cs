using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class SimpleProceduralMesh : MonoBehaviour
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
			new Vector3(1f,0f,1f), new Vector3(1f,1f,1f),
			new Vector3(0f,0f,1f), new Vector3(0f, 1f, 1f)
		};

		mesh.triangles = new int[]
		{
			0,2,1, //front
			1, 2, 3, 
			1, 3, 4, //left
			4, 3, 5,
			4, 5, 6, //back
			6, 5, 7,
			6, 7, 0, //right
			0, 7, 2,
			2, 7, 3, //top
			3, 7, 5,
			1, 4, 0, //bottom
			0, 4, 6

		};

		mesh.normals = new Vector3[]
		{
			Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back,
		};

		mesh.uv = new Vector2[] {
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
		};

		GetComponent<MeshFilter>().mesh = mesh;
	}
}
