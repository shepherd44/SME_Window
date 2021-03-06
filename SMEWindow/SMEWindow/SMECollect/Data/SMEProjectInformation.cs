﻿using System;
using System.Xml.Linq;

namespace SME.SMECollect.Data
{
    // 현재 프로그램의 정보 수집
    [Serializable]
    public class SMEProjectInformation
    {
        #region Members
        //projectName
        public string Name { get; set; }
        //projectVersion
        public Version m_Version { get; set; }
        #endregion

        #region Constructor
        public SMEProjectInformation(string name, Version version)
        {
            Name = name != null ? name : "My Project";
            m_Version = version != null ? version : new Version("0.0");
        }
        
        public SMEProjectInformation(SMEProjectInformation proinfo)
        {
            Name = proinfo.Name;
            m_Version = new Version(proinfo.m_Version.ToString());
        }

        public SMEProjectInformation(XElement xelement)
        {
            LoadFromXElement(xelement);
        }
        #endregion

        #region Functions
        public XElement ToXElement()
        {
            XElement xmldoc = new XElement("ProjectInformation",
                                    new XElement("Name", Name),
                                    new XElement("Version", m_Version.ToString())
                                    ); 
            return xmldoc;
        }

        public void LoadFromXElement(XElement xelement)
        {
            if(xelement.Name.ToString().Equals("ProjectInformation"))
            {
                foreach (XElement item in xelement.Elements())
                {
                    if (item.Name.ToString().Equals("Name"))
                        Name = item.Value;
                    else if (item.Name.ToString().Equals("Version"))
                        m_Version = new Version(item.Value);
                }
            }
        }

        override public string ToString() { string temp = "Project Name:" + Name + ":Version:" + m_Version; return temp; }
        #endregion
    }
}
