using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Reflection;
using Word = Microsoft.Office.Interop.Word;
using Traffic;

namespace Traffic.WordTemplates
{
    public abstract class BaseWordTemplate : IDisposable
    {
        private Word.Application _appWord;
        public Word.Document DocWord { get; private set; }

        public string Title { get; private set; }

        protected BaseWordTemplate(string fileName)
        {
            _appWord = new Word.Application
            {
                Visible = false,
                DisplayAlerts = Word.WdAlertLevel.wdAlertsNone
            };
            var path = Path.Combine(HttpContext.Current.Request.PhysicalApplicationPath, "App_Data", fileName);
            DocWord = _appWord.Documents.Add(path, Type.Missing, Type.Missing, Type.Missing);
            Title = (string)GetWordDocumentPropertyValue(DocWord, "Title");

        }

        private static object GetWordDocumentPropertyValue(Word._Document document, string propertyName)
        {
            object builtInProperties = document.BuiltInDocumentProperties;
            var builtInPropertiesType = builtInProperties.GetType();
            var property = builtInPropertiesType.InvokeMember("Item", BindingFlags.GetProperty, null, builtInProperties, new object[] { propertyName });
            var propertyType = property.GetType();
            var propertyValue = propertyType.InvokeMember("Value", BindingFlags.GetProperty, null, property, new object[] { });
            return propertyValue;
        }

        protected string GetVariable(string name)
        {
            return DocWord.Variables[name].Value;
        }

        protected void SetVariable(string name, string value)
        {
            DocWord.Variables[name].Value = value;
            DocWord.Fields.Update();
        }

        protected Word.Table GetTable(string name)
        {
            return DocWord.Bookmarks[name].Range.Tables[1];
        }

        public void Dispose()
        {
            if (DocWord != null)
            {
                DocWord.Saved = true;
                DocWord.Close(Type.Missing, Type.Missing, Type.Missing);
                DocWord = null;
            }
            if (_appWord != null)
            {
                _appWord.Quit(Type.Missing, Type.Missing, Type.Missing);
                _appWord = null;
            }
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
