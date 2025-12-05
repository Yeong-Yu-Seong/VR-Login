using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UserLogin : MonoBehaviour
{
    [SerializeField]
    private TMP_InputField usernameInput;
    [SerializeField]
    private TMP_InputField passwordInput;
    private string correctUsername = "yu seong";
    private string correctPassword = "password";
    [SerializeField]
    private TextMeshProUGUI errorMessage;
    public void OnLoginButtonClicked()
    {
        string enteredUsername = usernameInput.text;
        string enteredPassword = passwordInput.text;

        if (enteredUsername == correctUsername && enteredPassword == correctPassword)
        {
            errorMessage.text = "";
            SceneManager.LoadScene("TestScene");
        }
        else
        {
            errorMessage.text = "Invalid username or password. Please try again.";
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
