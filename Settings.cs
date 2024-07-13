using System;
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

        public string Entity { get; set; } // The entity that is being loaded to
        public string CrmAction { get; set; } // The action being run
        public string OptionSetValuesOrLabel { get; set; } // Whether option sets are values or labels
        public string LookupFoundMultipleRecords { get; set; } // What to do if multiple records are found in a lookup
        public string KeyFoundMultipleRecords { get; set; } // What to do if multiple records are found for the updated or deleted record
        public SerializableDataTable XMLTableMapping { get; set; } // An XML serializable version of the mapping table between the source and the destination
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
                Instance.XMLTableMapping = tempSettings.XMLTableMapping;
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