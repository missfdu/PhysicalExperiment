using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace myApp
{
    class Program
    {
        static void Main()
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(context.Server.MapPath("~/XMLFile.xml"));
            XmlNode xn = xml.DocumentElement;
            foreach (XmlNode node in xn.ChildNodes)
            {
              if (node.Name == "content")
              {
                foreach(xmlNode node1 in node.ChildNodes)
                {
                  if (node1.Name == "Question")
                  {
                    foreach(xmlNode node2 in node1.ChildNodes)
                    {
                      if(node2.Name == "CheckPoint")
                      {
                        foreach(xmlNode node3 in node2.ChildNodes)
                        {
                          if(node3.Name == "TestTarget")
                          {
                            foreach(xmlNode node4 in node3.ChildNodes)
                            {
                              if(node4.Name == "Group")
                              {
                                foreach(xmlNode node5 in node4.ChildNodes)
                                {
                                  if(node5.Name == "Para")
                                  {
                                    node5["RealScore"].InnerText = node5["TotalScore"].InnerText;
                                    node5["RealResult"].InnerText = node5["StdResult"].InnerText;
                                    foreach(xmlNode node6 in node5.ChildNodes)
                                    {
                                      if(node6.Name == "Para")
                                      {
                                        node6["RealScore"].InnerText = node6["TotalScore"].InnerText;
                                        node6["RealResult"].InnerText = node6["StdResult"].InnerText;
                                      }
                                    }
                                  }
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
            xml.Save(context.Server.MapPath("~/XMLFile.xml"));
            Console.WriteLine("Hello World!");
        }
    }
}

