using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using ProblemTracker.Models.LiquibaseModels;
using System.IO;

namespace ProblemTracker.Helper
{
    public class XMLHelper
    {

        internal static ChangeLog ObjectFromPath(string path)
        {
            ChangeLog response = new ChangeLog();
            XmlDocument doc = new XmlDocument();
            doc.Load(path);
            var changeLog = doc["databaseChangeLog"];
            foreach (XmlLinkedNode node in changeLog)
            {
                if (node.Attributes != null)
                {
                    string author = node.Attributes["author"].Value;
                    string id = node.Attributes["id"].Value;

                    ChangeSet set = new ChangeSet(author, id);
                    foreach (XmlNode _node in node.ChildNodes)
                        foreach (XmlNode sql in _node)
                        {
                            set.Sql.Add(sql.Value);
                        }
                        //{
                        //    set.Sql.Add(sql.Value);
                        //}

                    response.ChangeSets.Add(set);
                }
                else 
                {

                    }
            }
            return response;
        }

        internal static XmlNodeList Properties(string path)
        {
            XmlDocument doc = new XmlDocument();
            TextReader reader = new StreamReader(path);
            doc.Load(reader);
            XmlNodeList nodes = doc.GetElementsByTagName("changeSet");
            return nodes;
        }

        internal static string Seralize(ChangeSet changeSet, string path)
        {
            string response = string.Empty;
            if (changeSet.Sql != null)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                var _changeSet = doc.CreateElement("changeSet");
                _changeSet.SetAttribute("sql", changeSet.Sql[0]);

                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                XmlWriterSettings writerSettings = new XmlWriterSettings();
                writerSettings.OmitXmlDeclaration = true;
                writerSettings.Indent = true;

                XmlSerializer seralizer = new XmlSerializer(typeof(ChangeSet));
                using (StringWriter stringWriter = new StringWriter())
                {
                    using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, writerSettings))
                    {

                        seralizer.Serialize(xmlWriter, _changeSet, ns);
                        response = stringWriter.ToString();
                    }
                }

                //var changeLog = doc["databaseChangeLog"];
                //changeLog.AppendChild(doc.CreateNode(XmlNodeType.Element, "changeSet", path));
                //changeLog.LastChild.AppendChild(doc.CreateNode(XmlNodeType.Element, "sql", path));
                //changeLog.LastChild["sql"].InnerText = changeSet.Sql[0].ToString();

                //using (var sw = new StringWriter())
                //{
                //    using (var xw = new XmlTextWriter(sw))
                //    {
                //        var p = xw.Settings;
                //        xw.Formatting = Formatting.Indented;
                //        changeLog.LastChild.WriteTo(xw);
                //    }
                //    return sw.ToString();
                //}
             
               // doc.InsertBefore(doc.CreateNode(XmlNodeType.Element, "sql", path), doc["changeSet"]);




                var node = doc["databaseChangeLog"].LastChild;

                //XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                //ns.Add("", "");
                //XmlWriterSettings writerSettings = new XmlWriterSettings();
                //writerSettings.OmitXmlDeclaration = true;
                //writerSettings.Indent = true;
                
                //XmlSerializer seralizer = new XmlSerializer(typeof(ChangeSet));
                //using (StringWriter stringWriter = new StringWriter())
                //{
                //    using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter, writerSettings))
                //    {
                        
                //        seralizer.Serialize(xmlWriter, changeSet, ns);
                //        response = stringWriter.ToString();
                //    }
                //}
            }
            return response; 
        }


        internal static void Save(ChangeLog Log, string path)
        {
            //XmlDocument doc = new XmlDocument();
            //doc.Load(path);
            //var test = doc;
            


            //XmlSerializer writer = new XmlSerializer(typeof(ChangeLog.databaseChangeLog));
            
            //StreamWriter file = new StreamWriter(path);
            //writer.Serialize(file, Log);
            //file.Close();

            //rewrite this 
            
        }

        internal static void Save(ChangeSet changeSet, string path)
        {
            
        }
    }
}
