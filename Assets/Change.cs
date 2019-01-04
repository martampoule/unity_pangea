using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change : MonoBehaviour {

	public Material[] material;
	Renderer rend;
	static int index = 0;
	private int currentDataSet = 0;


	string[] text = {
		"Giurassico Inferiore",     // 0
		"Giurassico Medio",     // 1
		"Tardo Giurassico",     // 2
		"Cretaceo Inferiore", 
		"Cretaceo Medio",
		"Cretaceo Superiore",
		"Cretaceo Terziario",
		"Eocene",
		"Oligocene",
		"Miocene",
		"Presente",
	};

	// Use this for initialization
	void Start () 
	{
		
		rend = GetComponent<Renderer> ();
		rend.enabled = true;
		rend.sharedMaterial = material [currentDataSet];

		AggiornaLabel(currentDataSet);
	}


	void AggiornaLabel(int t){
		TextMesh textObject = GameObject.Find("MyText").GetComponent<TextMesh>();
		textObject.text = text[t];
	}


	// Update is called once per frame


	void OnGUI(){
		Event e = Event.current;
		if (e.type == EventType.MouseDown){			
			currentDataSet = (currentDataSet + 1) % 11;
			rend.sharedMaterial = material[currentDataSet];

			// carica i dati per i tasti:



			AggiornaLabel(currentDataSet);

		}			
	}
				
	}



