﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace BPMNET.Bpmn
{
    [GeneratedCode("xsd", "4.0.30319.1")]
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL")]
    [XmlRoot("startEvent", Namespace = "http://www.omg.org/spec/BPMN/20100524/MODEL", IsNullable = false)]
    public partial class tStartEvent : tCatchEvent
    {

        private bool isInterruptingField;

        public tStartEvent()
        {
            isInterruptingField = true;
        }

            [XmlAttribute()]
        [DefaultValue(true)]
        public bool isInterrupting
        {
            get
            {
                return isInterruptingField;
            }
            set
            {
                isInterruptingField = value;
            }
        }
    }
}
