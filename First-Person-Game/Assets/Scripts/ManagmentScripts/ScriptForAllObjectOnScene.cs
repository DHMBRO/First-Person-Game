using UnityEngine;

public class ScriptForAllObjectOnScene : MonoBehaviour
{
    [SerializeField] private int _identity;
    
    public void SetupIdentity(IdentificationControler identificationControler)
    {
        _identity = identificationControler.ReturnTotalIdentity();
    }

    public int ReturnIdentity()
    {
        return _identity;
    }
}
