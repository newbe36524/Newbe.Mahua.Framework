using System;

namespace Newbe.Mahua.ItemTemplateGenerator
{
    public class MahuaEventDesciptor
    {
        /// <summary>
        /// 描述
        /// </summary>
        public string Summary { get; set; }

        /// <summary>
        /// 接口名称
        /// </summary>
        public string Name { get; set; }

        public Type Type { get; set; }

        public Type MethodContextType { get; set; }

        public string MethodName { get; set; }

        public string MethodContextName { get; set; }
    }
}
