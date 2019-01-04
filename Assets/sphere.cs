using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
	Material m_Material;

	void Start()
	{
		//Fetch the Material from the Renderer of the GameObject
		m_Material = GetComponent<Renderer>().material;
		print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.A))
		{
			//Output the amount of materials before GameObject is destroyed
			print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
			//Destroy GameObject
			Destroy(gameObject);
		}
	}

	void OnMouseOver()
	{
		// Change the Color of the GameObject when the mouse hovers over it
		m_Material.color = Color.red;
	}

	void OnMouseExit()
	{
		//Change the Color back to white when the mouse exits the GameObject
		m_Material.color = Color.white;
	}

	void OnDestroy()
	{
		//Destroy the instance
		Destroy(m_Material);
		//Output the amount of materials to show if the instance was deleted
		print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
	}
}