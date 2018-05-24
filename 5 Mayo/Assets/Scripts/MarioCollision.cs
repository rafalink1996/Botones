using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter (Collision collision) {
		//1. Eliminar la pantalla actual que en este caso es ScreenGame
		GameObject.Destroy(GameObject.Find("Canvas/ScreenGame"));
		//2. Cargamos el prefab de ScreenSelection
		GameObject screenSelection = GameObject.Instantiate(Resources.Load("UI/Screens/WinScreen") as GameObject);
		screenSelection.name = "WinScreen";
		//3. Obtenemos una referencia al Canvas
		GameObject canvas = GameObject.Find ("Canvas");
		//4. Hacemos que sea hijo del Canvas
		screenSelection.transform.parent = canvas.transform;
		//5. Corregimos la posicion de los vertices comparados con los anchors
		screenSelection.GetComponent <RectTransform>().sizeDelta = Vector2.zero;
		screenSelection.GetComponent <RectTransform> ().localPosition = Vector2.zero;

	}
}
