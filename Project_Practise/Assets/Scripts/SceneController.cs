using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // 씬 이름 상수 정의 (실수를 줄이기 위해)
    private const string LoginSceneName = "LogIN";
    private const string TowerSceneName = "Tower";
    private const string CharacterSelectSceneName = "CharSelect";
    private const string CameraSceneName= "Camera";
    private const string GatchaSceneName= "Gatcha";

    // 로그인 → 타워 씬으로 이동
    public void GoToTower()
    {
        SceneManager.LoadScene(TowerSceneName);
    }

    // 타워 → 로그인 씬으로 돌아가기
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

    // 현재 씬 이름 출력 (디버깅용)
    public void PrintCurrentSceneName()
    {
        Debug.Log("현재 씬: " + SceneManager.GetActiveScene().name);
    }

    // 앱 종료 (PC에서만 작동)
    public void QuitGame()
    {
        Debug.Log("게임 종료");
        Application.Quit();
    }
}
