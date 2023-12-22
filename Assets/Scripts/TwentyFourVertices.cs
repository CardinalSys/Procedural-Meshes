using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class TwentyFourVertices : MonoBehaviour
{

	public List<Vector4> tangents = new List<Vector4>
		{
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


	private void CreateMesh()
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
			0, 2, 1,
			1, 2, 3,
			4, 6, 5,
			5, 6, 7,
			8, 10, 9,
			9, 10, 11,
			12, 14, 13,
			13, 14, 15,
			16, 18, 17,
			17, 18, 19,
			20, 21, 22,
			21, 23, 22,
		};


		mesh.normals = new Vector3[]
		{
			Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back,
			Vector3.forward, Vector3.forward, Vector3.forward, Vector3.forward, Vector3.forward, Vector3.forward, Vector3.forward, Vector3.forward,
			Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back,
		};

		mesh.uv = new Vector2[]{
			//Front
			new Vector2(0.0f, 0.0f),
			new Vector2(0.333f, 0.0f),
			new Vector2(0.0f, 0.333f),
			new Vector2(0.333f, 0.333f),

			//Right
			new Vector2(0.667f, 0.334f),
			new Vector2(1.0f, 0.334f),
			new Vector2(0.667f, 0.666f),
			new Vector2(1.0f, 0.666f),
			

			// Back
			new Vector2(0.667f, 0.0f),
			new Vector2(1.0f, 0.0f),
			new Vector2(0.667f, 0.333f),
			new Vector2(1.0f, 0.333f),

			// Left
			new Vector2(0.334f, 0.334f),
			new Vector2(0.666f, 0.334f),
			new Vector2(0.334f, 0.666f),
			new Vector2(0.666f, 0.666f),

			// Top
			new Vector2(0.334f, 0.0f),
			new Vector2(0.666f, 0.0f),
			new Vector2(0.334f, 0.333f),
			new Vector2(0.666f, 0.333f),


			// Bottom
			new Vector2(0.0f, 0.666f),
			new Vector2(0.333f, 0.666f),
			new Vector2(0.0f, 0.334f),
			new Vector2(0.333f, 0.334f),

		};

		mesh.tangents = new Vector4[]
		{
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

	private void OnEnable()
	{
		CreateMesh();
	}
}
