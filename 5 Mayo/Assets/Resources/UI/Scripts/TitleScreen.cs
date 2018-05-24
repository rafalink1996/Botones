using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void onClickPlay() {
		//1. Eliminar la pantalla actual
		GameObject.Destroy(this.gameObject);
		//2. Cargamos el prefab de ScreenSelection
		GameObject screenSelection = GameObject.Instantiate(Resources.Load("UI/Screens/ScreenSelection") as GameObject);
		screenSelection.name = "ScreenSelection";
		//3. Obtenemos una referencia al Canvas
		GameObject canvas = GameObject.Find ("Canvas");
		//4. Hacemos que sea hijo del Canvas
		screenSelection.transform.parent = canvas.transform;
		//5. Corregimos la posicion de los vertices comparados con los anchors
		screenSelection.GetComponent <RectTransform>().sizeDelta = Vector2.zero;
		screenSelection.GetComponent <RectTransform> ().localPosition = Vector2.zero;
	}
}
