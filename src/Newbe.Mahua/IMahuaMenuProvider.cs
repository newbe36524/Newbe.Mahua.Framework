using System.Collections.Generic;

namespace Newbe.Mahua
{
    public interface IMahuaMenuProvider
    {
        /// <summary>
        /// 生成菜单列表
        /// </summary>
        /// <returns></returns>
        IEnumerable<MahuaMenu> GetMenus();
    }
}
