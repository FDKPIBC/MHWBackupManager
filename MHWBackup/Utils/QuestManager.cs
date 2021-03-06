﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace MHWBackup.Utils
{
    public class QuestManager
    {
        public List<Quest> Quests { get; private set; }

        /// <summary>
        /// 源html
        /// </summary>
        public string OriginHtml { get; private set; }

        private object _lockobj;

        private HtmlDocument _questDocument;

        public QuestManager()
        {
            _questDocument = new HtmlDocument();
            Quests = new List<Quest>();
            _lockobj = new object();
        }

        public void LoadQuest()
        {
            OriginHtml = HttpHelper.Factory.Get("http://game.capcom.com/world/steam/hk/schedule.html").Result;
            _questDocument.LoadHtml(OriginHtml);
            var tableContainer = LoadQuestBaseNode();
            var tables = tableContainer.SelectNodes("table");
            foreach (HtmlNode table in tables)
            {
                var type = table.GetAttributeValue("table2", "table") == "table2" ? "活動任務" : "挑戰任務";
                Quests.AddRange(table.SelectNodes("tbody/tr").Select(t => CreateQuest(t, type)));
            }
            //Quests = Quests.OrderBy(t => t.StartTime).ToList();
        }

        public Quest CreateQuest(HtmlNode node, string type)
        {
            var quest = new Quest();
            quest.Image = node.SelectSingleNode(@"td[@class='image']/img").GetAttributeValue("src", string.Empty);
            quest.LevelLimit = node.SelectSingleNode(@"td[@class='level']/span").InnerText;
            var questNode = node.SelectSingleNode(@"td[@class='quest']");
            quest.Title = questNode.SelectSingleNode(@"div[@class='title']/span").InnerText;
            quest.TimeTerms = questNode.SelectSingleNode(@"p[@class='terms']").InnerText.ReplaceAndTrim("舉辦期間", "");
            //暂时无卵用
            //var timestr = quest.TimeTerms.Split('〜');
            //var startTime = DateTime.Now.Year + "-" + timestr[0];
            //var endTime = DateTime.Now.Year + "-" + timestr[1].Substring(1);
            //quest.StartTime = DateTime.Parse(startTime);
            //quest.EndTime = DateTime.Parse(endTime);
            quest.Content = questNode.SelectSingleNode(@"p[@class='txt']").InnerText;
            var popNode = questNode.SelectSingleNode(@"div[@class='pop']");
            quest.QuestMap = popNode.SelectSingleNode(@"ul/li[1]/span").InnerText;
            quest.QuestTerms = popNode.SelectSingleNode("ul/li[2]/span").InnerText.ReplaceAndTrim();
            quest.QuestRequest = popNode.SelectSingleNode("ul/li[3]/span").InnerText.ReplaceAndTrim();
            return quest;
        }

        private HtmlNode LoadQuestBaseNode() => _questDocument.DocumentNode.SelectSingleNode(@"/html[1]/body[1]/div[1]/div[1]/div[1]/section[1]/div[1]/div[2]");
    }
}
