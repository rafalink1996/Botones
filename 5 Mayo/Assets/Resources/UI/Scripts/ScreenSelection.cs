using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSelection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onClickMario() {
		//1. Eliminar la pantalla actual
		GameObject.Destroy(this.gameObject);
		//2. Cargamos el prefab de ScreenSelection
		GameObject screenSelection = GameObject.Instantiate(Resources.Load("UI/Screens/ScreenGame") as GameObject);
		screenSelection.name = "ScreenGame";
		//3. Obtenemos una referencia al Canvas
		GameObject canvas = GameObject.Find ("Canvas");
		//4. Hacemos que sea hijo del Canvas
		screenSelection.transform.parent = canvas.transform;
		//5. Corregimos la posicion de los vertices comparados con los anchors
		screenSelection.GetComponent <RectTransform>().sizeDelta = Vector2.zero;
		screenSelection.GetComponent <RectTransform> ().localPosition = Vector2.zero;
		//Cargamos el Nivel 1
		GameObject level1 = GameObject.Instantiate(Resources.Load("Levels/Level1") as GameObject);
		level1.name = "Level1";
		GameObject mario = GameObject.Instantiate(Resources.Load("Characters/Mario") as GameObject);
		mario.name = "Mario";
		GameObject level = GameObject.Find ("Level1");
		mario.transform.parent = level.transform;
	}
	public void onClickLuigi() {
		//1. Eliminar la pantalla actual
		GameObject.Destroy(this.gameObject);
		//2. Cargamos el prefab de ScreenSelection
		GameObject screenSelection = GameObject.Instantiate(Resources.Load("UI/Screens/ScreenGame") as GameObject);
		screenSelection.name = "ScreenGame";
		//3. Obtenemos una referencia al Canvas
		GameObject canvas = GameObject.Find ("Canvas");
		//4. Hacemos que sea hijo del Canvas
		screenSelection.transform.parent = canvas.transform;
		//5. Corregimos la posicion de los vertices comparados con los anchors
		screenSelection.GetComponent <RectTransform>().sizeDelta = Vector2.zero;
		screenSelection.GetComponent <RectTransform> ().localPosition = Vector2.zero;
		GameObject level1 = GameObject.Instantiate(Resources.Load("Levels/Level1") as GameObject);
		level1.name = "Level1";
		GameObject luigi = GameObject.Instantiate(Resources.Load("Characters/Luigi") as GameObject);
		luigi.name = "Luigi";
		GameObject level = GameObject.Find ("Level1");
		luigi.transform.parent = level.transform;
	}
}
