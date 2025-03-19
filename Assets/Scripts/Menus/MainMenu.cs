using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject panel_options;
	public GameObject Tutorielpanel; // Assigne le panel dans l'inspecteur Unity
	
	void Start(){
		UnshowOptions();
		UnshowTutoriel();
	}
	
	public void PlayGame(){
		SceneManager.LoadScene("Level1");
	}
	
	public void ShowOptions(){
		panel_options.SetActive(true);
	}
	
	public void UnshowOptions(){
		panel_options.SetActive(false);
	}
	
	public void ShowTutoriel(){
		Tutorielpanel.SetActive(true);
	}
	
	public void UnshowTutoriel(){
		Tutorielpanel.SetActive(false);
	}
	public void QuitGame(){
		Application.Quit();
	}
}
