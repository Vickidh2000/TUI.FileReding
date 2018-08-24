using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FileReading
{
    public class ReadXmlFile : ReadFile
    {
        public override object ReadingdFiles(string fileLocation)
        {

            string[] sitemaps = Directory.GetFiles(fileLocation);
            StreamWriter sw = new StreamWriter(@"\locs.txt", true);

            var res = new List<string>();

            // loop through each file 
            foreach (string sitemap in sitemaps)
            {
                try
                {
                    // new xdoc instance 
                    XmlDocument xDoc = new XmlDocument();

                    //load up the xml from the location 
                    xDoc.Load(sitemap);

                    // cycle through each child noed 
                    foreach (XmlNode node in xDoc.DocumentElement.ChildNodes)
                    {
                        // first node is the url ... have to go to nexted loc node 
                        foreach (XmlNode locNode in node)
                        {
                            // thereare a couple child nodes here so only take data from node named loc 
                            if (locNode.Name == "name")
                            {
                                // get the content of the loc node 
                                string loc = locNode.InnerText;

                                res.Add(loc);

                                sw.Write(loc + Environment.NewLine);
                            }
                        }
                    }
                }
                catch { }
            }

            return res;
        }

    }
}
