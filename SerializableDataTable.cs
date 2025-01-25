using System.Data;
using System.Xml.Serialization;

[XmlRoot("DataTable")]
public class SerializableDataTable
{
    [XmlElement("Table")]
    public DataTable Table { get; set; }

    public SerializableDataTable() { }

    public SerializableDataTable(DataTable table)
    {
        Table = table;
    }
}