using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public class TwentyFourVertices : MonoBehaviour
{
	public List<Vector3> vertices = new List<Vector3>
		{
			new Vector3(0,0,0), new Vector3(1f,0,0), new Vector3(0,1f,0), new Vector3(1f,1f,0),
			new Vector3(1f,0,0), new Vector3(1f,0,1f), new Vector3(1f,1f,0), new Vector3(1f,1f,1f),
			new Vector3(1f,0,1f), new Vector3(0,0,1f), new Vector3(1f,1f,1f), new Vector3(0,1f,1f),
			new Vector3(0,0,1f), new Vector3(0,0,0), new Vector3(0,1f,1f), new Vector3(0,1f,0),
			new Vector3(0,1f,0), new Vector3(1f,1f,0), new Vector3(0,1f,1f), new Vector3(1f,1f,1f),
			new Vector3(0,0,0), new Vector3(1f,0,0), new Vector3(0,0,1f), new Vector3(1f,0,1f),

		};

	public List<int> triangles = new List<int>
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

	public List<Vector3> normals = new List<Vector3>
		{
			Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back,
			Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back,
			Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back, Vector3.back,

		};



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
	public void RemoveVertice(Vector3 hitPos)
	{
		float distance = 1;
		//Calculate closest vertice
		Vector3 closestVertice = new(2f,2f,2f);
		foreach(Vector3 ver in vertices)
		{
			if (ver.z != hitPos.z)
				continue;
			float newDist = Mathf.Sqrt(Mathf.Pow(hitPos.x - ver.x, 2) + Mathf.Pow(hitPos.y - ver.y, 2));
			if (newDist < distance)
			{
				distance = newDist;
				closestVertice = ver;
			}
		}

		Debug.Log("Dist: " + distance + "Ver: " + closestVertice);
		int index = vertices.IndexOf(closestVertice);
		//obtener el mayor multipo de 3 que sea menor que index
		int startIndex = 0;
		for(int i = 0; i < 3; i++)
		{
			if(index - i % 3 == 0)
			{
				startIndex = index - i;
				break;
			}
		}

		//vertices.Remove(closestVertice);
		triangles.RemoveRange(startIndex, 3);

		CreateMesh();
	}


	private void CreateMesh()
	{
		var mesh = new Mesh
		{
			name = "Procedural Mesh"
		};

		mesh.vertices = vertices.ToArray();

		mesh.triangles = triangles.ToArray();


		mesh.normals = normals.ToArray();

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

		mesh.tangents = tangents.ToArray();

		GetComponent<MeshFilter>().mesh = mesh;
	}

	private void OnEnable()
	{
		CreateMesh();
	}
}
