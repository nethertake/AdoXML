﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AdoXML
{
    class Program
    {
        static void Main(string[] args)
        {

            Exmpl_01();

        }

        public static void Exmpl_01()
        {
            XElement xBook = new XElement("BookParticipants",
                new XElement("BookParticipant", new XAttribute("type", "Author")),
                new XElement("FirstName", "Joe"),
                new XElement("LastName", "Rattz"),

                new XElement("BookParticipant", new XAttribute("type", "Editor")),
                new XElement("FirstName", "Buckingham"),
                new XElement("LastName", "Rattz")
                );

            Console.WriteLine(xBook.ToString());


        }

    }
}