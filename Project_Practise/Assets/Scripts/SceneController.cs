using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // �� �̸� ��� ���� (�Ǽ��� ���̱� ����)
    private const string LoginSceneName = "LogIN";
    private const string TowerSceneName = "Tower";
    private const string CharacterSelectSceneName = "CharSelect";
    private const string CameraSceneName= "Camera";
    private const string GatchaSceneName= "Gatcha";

    // �α��� �� Ÿ�� ������ �̵�
    public void GoToTower()
    {
        SceneManager.LoadScene(TowerSceneName);
    }

    // Ÿ�� �� �α��� ������ ���ư���
    public void GoToLogin()
    {
        SceneManager.LoadScene(LoginSceneName);
    }
    public void GoToCharSelect()
    {
        SceneManager.LoadScene(CharacterSelectSceneName);
    }
    public void GoCameraScene()
    {
        SceneManager.LoadScene(CameraSceneName);
    }
    public void GoToGatcha()
    {
        SceneManager.LoadScene(GatchaSceneName);
    }

    // ���� �� �̸� ��� (������)
    public void PrintCurrentSceneName()
    {
        Debug.Log("���� ��: " + SceneManager.GetActiveScene().name);
    }

    // �� ���� (PC������ �۵�)
    public void QuitGame()
    {
        Debug.Log("���� ����");
        Application.Quit();
    }
}
