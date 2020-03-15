using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Model
{
    public enum Language
    {
        IT,
        EN,
        ES,
        DE
    }

    public class MainModel
    {
        protected MainModel(Language lang)
        {
            Lang = lang;
        }

        public Language Lang { get; protected set; }


        public static MainModel Create(Language lang)
        {
            return new MainModel(lang);
        }

        public static MainModel CreateIt()
        {
            return new MainModel(Language.IT);
        }

    }
}
