using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml;
using McTools.Xrm.Connection;

namespace DataImport
{
    public sealed class Settings
    {
        private static volatile Settings instance;
        private static object syncRoot = new Object();

        private Settings() { }

        public static Settings Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new Settings();
                    }
                }

                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public string Entity { get; set; }
        public string CrmAction { get; set; }
        public string OptionSetValuesOrLabel { get; set; }
        public string LookupFoundMultipleRecords { get; set; }
        public string KeyFoundMultipleRecords { get; set; }
        public void LoadSettingsFromXML(string filePath)
        {
            // Load settings from file
            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(filePath);
                Settings tempSettings = (Settings)XmlSerializerHelper.Deserialize(xmlDocument.OuterXml, typeof(Settings));
                
                Instance.Entity = tempSettings.Entity;
                Instance.CrmAction = tempSettings.CrmAction;
                Instance.OptionSetValuesOrLabel = tempSettings.OptionSetValuesOrLabel;
                Instance.LookupFoundMultipleRecords = tempSettings.LookupFoundMultipleRecords;
                Instance.KeyFoundMultipleRecords = tempSettings.KeyFoundMultipleRecords;
            }
            catch (Exception innerException)
            {
                throw new Exception("Error attempting to process setting file \"" + filePath + "\"", innerException);
            }
        }

        public void Reset()
        {
            Entity = null;
            CrmAction = null;
            OptionSetValuesOrLabel = null;
            LookupFoundMultipleRecords = null;
            KeyFoundMultipleRecords = null;
        }

    }
 

}