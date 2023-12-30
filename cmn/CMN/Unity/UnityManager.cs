using Unity;

namespace CMN;
public class UnityManager
{
    #region Property
    private static IUnityContainer _container;
    public static IUnityContainer Container
    {
        get
        {
            if (_container == null)
                _container = new UnityContainer();
            return _container;
        }
    }
    #endregion

}

