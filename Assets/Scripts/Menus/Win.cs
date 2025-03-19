using UnityEngine;
using UnityEngine.SceneManagement;

public class WinManager : MonoBehaviour
{
    public GameObject creditsPanel; // Assigne le panel dans l'inspecteur Unity


    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

	void Start(){
		UnshowCredits();
	}
	public void ShowCredits(){
		creditsPanel.SetActive(true);
	}
	
	public void UnshowCredits(){
		creditsPanel.SetActive(false);
	}
	

}
