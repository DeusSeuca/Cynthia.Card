﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cynthia.Card;
using Cynthia.Card.Common.Models;
using Newtonsoft.Json;
using UnityEngine;

namespace Assets.Script.Localization
{
    class LanguageManagerJson : ITranslator
    {
        private Dictionary<string, string> Texts = new Dictionary<string, string>();
        private List<GameLocale> _locales;
        private GameLocale _gameLanguage;
        public int GameLanguage
        {
            get => _locales.IndexOf(_gameLanguage);
            set
            {
                if (value >= _locales.Count || value < 0)
                {
                    value = 0;
                }
                _gameLanguage = _locales[value];
                LoadTexts();
                TranslateCards();
            }
        }

        public List<string> LanguageNames => _locales.Select(l => l.Name).ToList();
        public List<string> LanguageFilenames => _locales.Select(l => l.Filename).ToList();


        public LanguageManagerJson()
        {
            LoadAvailableLocales();
            GameLanguage = PlayerPrefs.GetInt("Language", 0);
        }

        public void LoadAvailableLocales()
        {
            var infoSerialized = Resources.Load<TextAsset>("Locales/info").text;
            _locales = JsonConvert.DeserializeObject<List<GameLocale>>(infoSerialized);
        }

        private void LoadTexts()
        {
            Texts.Clear();

            var localeFile = Resources.Load<TextAsset>($"Locales/{_gameLanguage.Filename}");
            if (localeFile != null)
            {
                Texts = JsonConvert.DeserializeObject<Dictionary<string, string>>(localeFile.text);
            }
        }

        public string GetText(string id)
        {
            return Texts.ContainsKey(id) ? Texts[id] : id;
        }

        public void TranslateCards()
        {
            var languageFile = Resources.Load<TextAsset>($"Locales/{_gameLanguage.Filename}-cards");
            if (languageFile == null)
            {
                return;
            }
            var allCardTexts = JsonConvert.DeserializeObject<Dictionary<string, CardTexts>>(languageFile.text);
            var newCardMap = new Dictionary<string, GwentCard>();

            var ids= GwentMap.CardMap.Keys;
            foreach (var id in ids)
            {
                var newCardData = GwentMap.CardMap[id];
                if (allCardTexts.ContainsKey(id))
                {
                    var currentCardTexts = allCardTexts[id];
                    newCardData.Name = currentCardTexts.Name;
                    newCardData.Info = currentCardTexts.Info;
                    newCardData.Flavor = currentCardTexts.Flavor;
                }
                newCardMap.Add(id, newCardData);
            }
            GwentMap.CardMap = newCardMap;
        }
    }
}