using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtVirtual_ini : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene0(string Menu_Virtua)
    {
        SceneManager.LoadScene(Menu_Virtua);
    }
    public void LoadScene1(string Menu_Principal)
    {
        SceneManager.LoadScene(Menu_Principal);
    }    
    public void LoadScene2(string Configuracao)
    {
        SceneManager.LoadScene(Configuracao);
    }
    public void LoadScene3(string Login)
    {
        SceneManager.LoadScene(Login);
    }
    public void LoadScene4(string Cadastro)
    {
        SceneManager.LoadScene(Cadastro);
    }
    public void LoadScene6(string Sair)
    {
        SceneManager.LoadScene(Sair);
    }
    public void LoadScene5(string Pre_Game)
    {
        SceneManager.LoadScene(Pre_Game);
    }
    public void Avalia() 
    {
        Application.OpenURL("https://goo.gl/maps/ZLh6ui9hFEiHeQsL9");
        Debug.Log("Esta Funcionando!");
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Sair()
    {
        Application.Quit();
    }
}
