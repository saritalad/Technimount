using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XMLDEMO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Details....");
            Console.WriteLine("Emp Id:");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Emp Name:");
            String name= Console.ReadLine();
            Console.WriteLine("Department: ");
            String dept = Console.ReadLine();
            Console.WriteLine("Birth Date :\n Date : ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Month: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Year: ");
            int y = int.Parse(Console.ReadLine());
                
            
                XmlDocument doc = new XmlDocument();
            //doc.LoadXml("D:\\chaitanyab\\emp.xml");
                //modify the path below if require
                XmlTextWriter xtw = new XmlTextWriter("z:\\emp.xml",Encoding.UTF8);

        xtw.WriteStartDocument();//start of doc
            xtw.WriteStartElement("Employees");//start of Employees
                xtw.WriteStartElement("Employee");//start of employee
                    xtw.WriteStartAttribute("id");//attribute
                        xtw.WriteValue(id);//wrote value of attribute 
   

                xtw.WriteStartElement("Name");
                    xtw.WriteString(name);
                xtw.WriteEndElement();

                xtw.WriteStartElement("birthDate");
                    xtw.WriteStartElement("day");
                        xtw.WriteValue(d);
                    xtw.WriteEndElement();

                    xtw.WriteStartElement("month");
                        xtw.WriteValue(m);
                    xtw.WriteEndElement();

                    xtw.WriteStartElement("year");
                    xtw.WriteValue(y);
                    xtw.WriteEndElement();//year
                    xtw.WriteEndElement();//birthdate
               xtw.WriteEndElement();//end of employee

            xtw.WriteEndElement();//end of employees 
            
            xtw.WriteEndDocument();//end of doc

            xtw.Flush();
            xtw.Close();
            Console.WriteLine("Done...... ");
            
            //modify the path below if require
            readmyxml("z:\\emp.xml");
            Console.ReadLine();
          //  searchmyemployee();

        }

        private static void searchmyemployee()
        {
            
        }

        private static void readmyxml(string path)
        {
            XmlTextReader xtr = new XmlTextReader(path);
            while (xtr.Read())
            {
                switch (xtr.NodeType)
                {
                    case XmlNodeType.Attribute:
                        Console.WriteLine("{0}",xtr.Name);
                        break;
                    case XmlNodeType.CDATA:
                        Console.WriteLine("<![CDATA[{0}]>", xtr.Value);
                        break;
                    case XmlNodeType.Comment:
                        Console.WriteLine("<!--{0}-->",xtr.Value);
                        break;
                    case XmlNodeType.Document:

                        break;
                    case XmlNodeType.DocumentFragment:
                        break;
                    case XmlNodeType.DocumentType:
                        Console.WriteLine("<!DOCTYPE {0} [{1}]",xtr.Name, xtr.Value);
                        break;
                    case XmlNodeType.Element:
                        Console.WriteLine("<{0}>", xtr.Name);
                        break;
                    case XmlNodeType.EndElement:
                        Console.WriteLine("</{0}>", xtr.Name);
                        break;
                    case XmlNodeType.EndEntity:
                        break;
                    case XmlNodeType.Entity:
                        break;
                    case XmlNodeType.EntityReference:
                        break;
                    case XmlNodeType.None:
                        break;
                    case XmlNodeType.Notation:
                        break;
                    case XmlNodeType.ProcessingInstruction:
                        break;
                    case XmlNodeType.SignificantWhitespace:
                        break;
                    case XmlNodeType.Text:
                        Console.WriteLine("{0}",xtr.Value);
                        break;
                    case XmlNodeType.Whitespace:
                        break;
                    case XmlNodeType.XmlDeclaration:
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
