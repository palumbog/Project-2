using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectMenuKeyboard : MonoBehaviour {

	public EventSystem eventSystem;
	public GameObject selectedObject;

	private bool buttonSelected;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		//this function allows us to navigate into the main menu with keyboard
		if (Input.GetAxisRaw ("Vertical") !=0 && buttonSelected == false)
		{
			eventSystem.SetSelectedGameObject(selectedObject);
			buttonSelected = true; 
		}			
	}

	private void onDisable()
	{
		buttonSelected = false;
	}	
}
