using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHWBackup.Utils
{
    public class Quest
    {
        /// <summary>
        /// 类型
        /// </summary>
        public string QuestType { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string Image { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 难度等级
        /// </summary>
        public string LevelLimit { get; set; }

        /// <summary>
        /// 地图
        /// </summary>
        public string QuestMap { get; set; }

        /// <summary>
        /// 参与条件
        /// </summary>
        public string QuestTerms { get; set; }

        /// <summary>
        /// 时间条件
        /// </summary>
        public string TimeTerms { get; set; }

        /// <summary>
        /// 任务要求
        /// </summary>
        public string QuestRequest { get; set; }
    }
}
