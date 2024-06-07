using UnityEngine;

public class IdentificationControler : MonoBehaviour
{
    [SerializeField] private string _nameOfScene;
    private int _totalIdentity;

    private void Update()
    {
        ChekAllGameObjects();
    }

    private void ChekAllGameObjects()
    {
        GameObject[] AllGameObjectsOnScene = UnityEngine.Object.FindObjectsOfType<GameObject>();

        for (int i = 0; i < AllGameObjectsOnScene.Length; i++) 
        {
            if (!AllGameObjectsOnScene[i].GetComponent<ScriptForAllObjectOnScene>())
            {
                ScriptForAllObjectOnScene NewScriptForAllObjectOnScene = AllGameObjectsOnScene[i].AddComponent<ScriptForAllObjectOnScene>();
                NewScriptForAllObjectOnScene.SetupIdentity(GetComponent<IdentificationControler>());
                _totalIdentity++;
            }
        }

    }

    public int ReturnTotalIdentity()
    {
        return _totalIdentity;
    }


}
