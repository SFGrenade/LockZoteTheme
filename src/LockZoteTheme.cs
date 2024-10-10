using JetBrains.Annotations;
using Modding;

namespace LockZoteTheme;

[UsedImplicitly]
public class LockZoteTheme : Mod
{
    public LockZoteTheme() : base("Lock Zote Menu Theme")
    {
        Platform.Current.EncryptedSharedData.SetInt("eternalOrdealMenu", 0);
    }

    public override void Initialize()
    {
    }
}