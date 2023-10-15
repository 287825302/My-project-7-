using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// ��������ת����
/// </summary>
public class LevelLoader : MonoBehaviour
{
    public static string LastScencs="";
    private void Start()
    {
        // �ָ�ʱ�������ٶ�Ϊ����ֵ
        Time.timeScale = 1;
    }

    /// <summary>
    /// ��ת��ָ������
    /// </summary>
    public void LoadScene(string sceneName)
    {
        Scene scene = SceneManager.GetActiveScene();
        LastScencs = scene.name;
        // �첽���س���
        AsyncOperation op = SceneManager.LoadSceneAsync(sceneName);
        
    }
    public void LoadLastScene()
    {
        if (LastScencs !="") 
        {
            LoadScene(LastScencs);
        }
       

       
    }

    /// <summary>
    /// ���¼��ص�ǰ����
    /// </summary>
    public void ReloadScene()
    {
        // ��ȡ��ǰ����ĳ���
        Scene scene = SceneManager.GetActiveScene();

        // �첽���ص�ǰ����
        AsyncOperation op = SceneManager.LoadSceneAsync(scene.name);
    }

    /// <summary>
    /// �˳���Ϸ
    /// </summary>
    public void ExitGame()
    {
        // �ر�Ӧ�ó���
        Application.Quit();
    }
}
