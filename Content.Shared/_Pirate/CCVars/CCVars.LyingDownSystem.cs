using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

public sealed partial class CCVars
{
    #region Lying Down System

    /// <summary>
    ///     When true, entities that fall to the ground will be able to crawl under tables and 
    ///     plastic flaps, allowing them to take cover from gunshots. 
    /// </summary>
    public static readonly CVarDef<bool> CrawlUnderTables =
        CVarDef.Create("rest.crawlundertables", false, CVar.REPLICATED);

    #endregion
}
