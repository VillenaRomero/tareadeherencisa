using UnityEngine;

public class baseentity : MonoBehaviour
{
    #region Variables
    private string entityname;
    private string description;
    #endregion
    #region Getters
    public string EntityName => entityname;
    public string Description => description;
    #endregion
    #region Methods
    public virtual void Set(string _entityName, string _description) {
        entityname = _entityName;
        description = _description;

    }
    #endregion
}
